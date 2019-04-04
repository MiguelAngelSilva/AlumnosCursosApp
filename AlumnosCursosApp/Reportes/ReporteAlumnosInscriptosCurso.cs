using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumnosCursosDAL.Models;
using AlumnosCursosApp.Utilities;
using AlumnosCursosDAL.Repos;
using AlumnosCursosApp.Reportes.DataSets;
using Microsoft.Reporting.WinForms;

namespace AlumnosCursosApp.Reportes
{
    public partial class ReporteAlumnosInscriptosCurso : Form
    {

        public ReporteAlumnosInscriptosCurso()
        {
            InitializeComponent();
        }

        public Curso CursoSeleccionado{ get; set; }
        

        private void ReporteAlumnosCursos_Load(object sender, EventArgs e)
        {
            if (CursoSeleccionado == null) return;
            this.rvAlumnosInscriptosCurso.RefreshReport();

            #region "Creacion de tabla"
            DataTable tabla = new DataTable();
            DataColumn col = new DataColumn("Id");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
             col = new DataColumn("Dni");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
             col = new DataColumn("Apellido");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
             col = new DataColumn("Nombre");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            #endregion
            foreach (var item in CursoSeleccionado.AlumnosCursos)
            {
                DataRow dr = tabla.NewRow();
              
                dr["Id"] = item.Alumno.Id.ToString();
                dr["Dni"] = item.Alumno.Dni.ToString();
                dr["Apellido"] = item.Alumno.Apellido.ToString();
                dr["Nombre"] = item.Alumno.Nombre.ToString();
                
                tabla.Rows.Add(dr);
            }
            this.rvAlumnosInscriptosCurso.LocalReport.ReportEmbeddedResource = "AlumnosCursosApp.Reportes.RptAlumnosInscriptosPorCurso.rdlc";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("pNombreCurso", CursoSeleccionado.NombreCurso);
            this.rvAlumnosInscriptosCurso.LocalReport.SetParameters(parameters);
            ReportDataSource rds1 = new ReportDataSource("Alumnos", tabla);
            this.rvAlumnosInscriptosCurso.LocalReport.DataSources.Clear();
            this.rvAlumnosInscriptosCurso.LocalReport.DataSources.Add(rds1);
            this.rvAlumnosInscriptosCurso.RefreshReport();
        }
    }
}
