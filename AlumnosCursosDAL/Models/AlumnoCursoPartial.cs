using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models.Base;

namespace AlumnosCursosDAL.Models
{
    public partial class AlumnoCurso
    {
        public override string ToString()
        {
            return $"Curso Id: {this.Curso.Id} - {this.Curso.NombreCurso}";
        }
    }
}
