namespace AlumnosCursosDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using AlumnosCursosDAL.Models.Base;

    [Table("Curso")]
    public partial class Curso:EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            AlumnosCursos = new HashSet<AlumnoCurso>();
        }

        [Required]
        public string NombreCurso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCurso> AlumnosCursos { get; set; }
    }
}
