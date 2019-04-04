using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumnosCursosApp.Reportes;
using LoggerPrueba;

namespace AlumnosCursosApp
{
    public partial class MDI : Form
    {
        private int childFormNumber = 0;

        public MDI()
        {
            InitializeComponent();
        }
        

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnABMAlumnos_Click(object sender, EventArgs e)
        {
            Form childFormAlumnos = new FrmAlumnos();
            childFormAlumnos.MdiParent = this;
            childFormAlumnos.Show();
        }

        private void btnABMCursos_Click(object sender, EventArgs e)
        {
            Form childFormCursos = new FrmCursos();
            childFormCursos.MdiParent = this;
            childFormCursos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form childFormReporteInscripcionCursos = new ReporteAlumnosInscriptosCurso();
            childFormReporteInscripcionCursos.MdiParent = this;
            childFormReporteInscripcionCursos.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
