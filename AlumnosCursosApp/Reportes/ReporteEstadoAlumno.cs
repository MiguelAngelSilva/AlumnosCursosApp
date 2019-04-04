using AlumnosCursosDAL.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosCursosApp.Reportes
{
    public partial class ReporteEstadoAlumno : Form
    {
        public ReporteEstadoAlumno()
        {
            InitializeComponent();
        }
        
        public Alumno AlumnoSeleccionado { get; set; }
        private void ReporteEstadoAlumno_Load(object sender, EventArgs e)
        {
            if (AlumnoSeleccionado == null) return;
             this.rvEstadoAlumno.RefreshReport();
            #region "Creacion de tabla"
            DataTable tabla = new DataTable();
            DataColumn col = new DataColumn("Id");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("NombreCurso");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("EnCurso");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("Aprobado");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            
            #endregion
            foreach (var item in AlumnoSeleccionado.AlumnosCursos)
            {
                DataRow dr = tabla.NewRow();
                
                string ec = string.Empty;
                if (item.EnCurso)
                {
                    ec = "Si";
                }
                else {
                    ec = "No";
                }
                string ap = string.Empty;
                if (item.Aprobado)
                {
                    ap = "Si";
                }
                else
                {
                    ap = "No";
                }
                dr["Id"] = item.Alumno.Id.ToString();
                dr["NombreCurso"] = item.Curso.NombreCurso;
                dr["EnCurso"] = ec;
                dr["Aprobado"] = ap;
                tabla.Rows.Add(dr);
            }
            this.rvEstadoAlumno.LocalReport.ReportEmbeddedResource = "AlumnosCursosApp.Reportes.rptEstadoAlumno.rdlc";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("pAlumno", AlumnoSeleccionado.ToString());
            this.rvEstadoAlumno.LocalReport.SetParameters(parameters);
            ReportDataSource rds1 = new ReportDataSource("Cursos", tabla);
            
            this.rvEstadoAlumno.LocalReport.DataSources.Clear();
            this.rvEstadoAlumno.LocalReport.DataSources.Add(rds1);
           
            this.rvEstadoAlumno.RefreshReport();
            this.rvEstadoAlumno.RefreshReport();
        }
    }
}
