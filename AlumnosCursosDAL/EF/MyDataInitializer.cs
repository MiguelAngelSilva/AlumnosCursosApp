using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlumnosCursosDAL.Models;

namespace AlumnosCursosDAL.EF
{
    public class MyDataInitializer : DropCreateDatabaseAlways<AlumnosCursosDAL.EF.AlumnosCursosEntities>
    {
        protected override void Seed(AlumnosCursosDAL.EF.AlumnosCursosEntities context)
        {
            var alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Dave", Apellido = "Brenner", Dni= "20724632"},
                new Alumno {Nombre = "Matt", Apellido = "Walton", Dni= "21547898"},
                new Alumno {Nombre = "Steve", Apellido = "Hagen", Dni= "23154893"},
                new Alumno {Nombre = "Pat", Apellido = "Walton", Dni= "25532145"},
                new Alumno {Nombre = "Bad", Apellido = "Customer", Dni= "28945264"},
            };
            alumnos.ForEach(x => context.Alumnos.AddOrUpdate(a => new { a.Nombre, a.Apellido, a.Dni }, x));
            var cursos = new List<Curso>
            {
                new Curso {NombreCurso = "C Sharp"},
                new Curso {NombreCurso = "VB.NET"},
                new Curso {NombreCurso = "JavaScript"},
                new Curso {NombreCurso = "HTML"},
                new Curso {NombreCurso = "CSS"}
            };
            cursos.ForEach(x => context.Cursos.AddOrUpdate(c => new { c.NombreCurso}, x));
            
        }
    }
}
