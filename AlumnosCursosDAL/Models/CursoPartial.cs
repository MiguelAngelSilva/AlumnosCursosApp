using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models.Base;

namespace AlumnosCursosDAL.Models
{
    public partial class Curso
    {
        public override string ToString() =>  $"Curso Id: {this.Id} - {this.NombreCurso}";
        public override bool Equals(object obj) => obj?.ToString() == ToString();
        public override int GetHashCode() => ToString().GetHashCode();
    }
}
