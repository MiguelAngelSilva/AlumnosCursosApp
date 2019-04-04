using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.EF;
using AlumnosCursosDAL.Models;

namespace AlumnosCursosDAL.Repos
{
    public class CursoRepo: BaseRepo<Curso>
    {
        public CursoRepo(AlumnosCursosEntities db) : base(db) { }
    }
}
