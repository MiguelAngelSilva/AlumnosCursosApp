using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models.Base;

namespace AlumnosCursosDAL.Models
{
    public partial class Alumno
    {
        public override string ToString()
        {
            return $"Alumno Id: {this.Id} - DNI: {this.Dni} - {this.Nombre} {this.Apellido}" ;
        }
    }
}
