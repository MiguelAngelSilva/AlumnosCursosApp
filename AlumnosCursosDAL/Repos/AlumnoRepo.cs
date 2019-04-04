using AlumnosCursosDAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models;

namespace AlumnosCursosDAL.Repos
{
    public class AlumnoRepo:BaseRepo<Alumno>
    {
        public AlumnoRepo(AlumnosCursosEntities db):base(db) { }
    }
}
