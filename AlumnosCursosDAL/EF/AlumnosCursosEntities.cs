namespace AlumnosCursosDAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using AlumnosCursosDAL.Models;

    public partial class AlumnosCursosEntities : DbContext
    {
        public AlumnosCursosEntities()
            : base("name=AlumnosCursosEntities2")
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<AlumnoCurso> AlumnosCursos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnosCursos)
                .WithRequired(e => e.Alumno)
                .HasForeignKey(e => e.Alumno_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.AlumnosCursos)
                .WithRequired(e => e.Curso)
                .HasForeignKey(e => e.Curso_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
