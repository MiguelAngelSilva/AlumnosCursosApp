using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models;
using AlumnosCursosDAL.EF;

namespace AlumnosCursosDAL.Repos
{
    public class AlumnoCursoRepo : BaseRepo<AlumnoCurso>
    {
        public AlumnoCursoRepo(AlumnosCursosEntities db) : base(db) { }
    }
}
