namespace AlumnosCursosDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using AlumnosCursosDAL.Models.Base;

    [Table("AlumnoCurso")]
    public partial class AlumnoCurso:EntityBase
    {
       
        public bool Aprobado { get; set; }

        public bool EnCurso { get; set; }

        public int Alumno_Id { get; set; }

        public int Curso_Id { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
