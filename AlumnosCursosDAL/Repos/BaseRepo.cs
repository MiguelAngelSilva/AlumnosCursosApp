using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using AlumnosCursosDAL.EF;
using AlumnosCursosDAL.Models.Base;
using LoggerPrueba.FactoryMethod.TypeMessage;
using LoggerPrueba;

namespace AlumnosCursosDAL.Repos
{
    public class BaseRepo<T> : IDisposable, IRepo<T> where T : EntityBase, new()
    {
        private readonly DbSet<T> _table;
        private readonly AlumnosCursosEntities _db;
        public BaseRepo(AlumnosCursosEntities db )
        {
            _db = db;//new AlumnosCursosEntities();
            _table = _db.Set<T>();
        }
        protected AlumnosCursosEntities Context => _db;
        public void Dispose()
        {
            _db?.Dispose();
        }
        internal int SaveChanges()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                TecsoLogger.LogMessage(new Error(ex.Message,MessageType.Error));
                //Thrown when there is a concurrency error
                //for now, just rethrow the exception
                throw;
            }
            catch (DbUpdateException ex)
            {
                TecsoLogger.LogMessage(new Error(ex.Message, MessageType.Error));
                //Thrown when database update fails
                //Examine the inner exception(s) for additional
                //details and affected objects
                //for now, just rethrow the exception
                throw;
            }
            catch (CommitFailedException ex)
            {
                TecsoLogger.LogMessage(new Error(ex.Message, MessageType.Error));
                //handle transaction failures here
                //for now, just rethrow the exception
                throw;
            }
            catch (Exception ex)
            {
                TecsoLogger.LogMessage(new Error(ex.Message, MessageType.Error));
                //some other exception happened and should be handled
                throw;
            }
        }
        public T GetOne(int? id) => _table.Find(id);
        public virtual List<T> GetAll() => _table.ToList();
        public List<T> ExecuteQuery(string sql) => _table.SqlQuery(sql).ToList();
        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects) => _table.SqlQuery(sql, sqlParametersObjects).ToList();
        public int Add(T entity)
        {
            try
            {
                _table.Add(entity);
                TecsoLogger.LogMessage(new Info($"Add new {entity}.", MessageType.Info));
                return SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public int AddRange(IList<T> entities)
        {
            try
            {
                _table.AddRange(entities);
                foreach (var item in entities)
                {
                    TecsoLogger.LogMessage(new Info($"Add new list of: {item}.", MessageType.Info));
                }

                return SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public int SaveRange(IList<T> entities)
        {
            try
            {
                foreach (var item in entities)
                {
                    _db.Entry(item).State = EntityState.Modified;
                }

                return SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public int Save(T entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;
                return SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public int Delete(int id, byte[] timeStamp)
        {
            try
            {
                _db.Entry(new T() { Id = id, Timestamp = timeStamp }).State = EntityState.Deleted;
                return SaveChanges();
            }
            catch (Exception ex) 
            {

                throw ex;
            }
           
        }
        public int Delete(T entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Deleted;
                TecsoLogger.LogMessage(new Info($"Delete {entity} - User: " + Environment.UserName, MessageType.Info));
                return SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
