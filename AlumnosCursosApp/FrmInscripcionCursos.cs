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
using System.Data.Entity;

namespace AlumnosCursosApp
{
    public partial class FrmInscripcionCursos : Form
    {
        Curso _curso;
        List<Curso> _lstCursos = new List<Curso>();
        CursoRepo _cursoRepo = new CursoRepo(UtilityHelper.GetDbContext());
        AlumnoCursoRepo _alumnoCursoRepo = new AlumnoCursoRepo(UtilityHelper.GetDbContext());
        List<AlumnoCurso> _lstAlumnoCursoSeleccionados = new List<AlumnoCurso>();
        AlumnoCurso _alumnoCurso = new AlumnoCurso();

        public FrmInscripcionCursos()
        {
            InitializeComponent();
        }
        
        #region Eventos
        private void FrmInscripcionCursos_Load(object sender, EventArgs e)
        {
            ObtenerCursos();
            SetearBoton();
            SetearTextBox();
            InicializarListaCursosSeleccionados();
            SetearDatosAlumno();
            SetearCheckBoxes();
        }
        private void txtBuscqueda_TextChanged(object sender, EventArgs e)
        {
            this.lstBusqueda.DataSource = _lstCursos.Where<Curso>(c => c.ToString().ToUpper().Contains(this.txtBuscqueda.Text.ToUpper())).ToList();

        }
        private void lstBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curso = lstBusqueda.SelectedItem as Curso;
            SetearTextBox();
        }
        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            var cTemp = _lstAlumnoCursoSeleccionados.Find(x => x.Curso.Equals(lstBusqueda.SelectedItem));
            if (cTemp != null) return; //Si el curso ya esta en la lista de cursos seleccionados salgo y no agreo el mismo curso a la lista.
            _lstAlumnoCursoSeleccionados.Add(new AlumnoCurso { Alumno = AlumnoSeleccionado,
                                                                Curso = lstBusqueda.SelectedItem as Curso ,
                                                                Alumno_Id = AlumnoSeleccionado.Id,
                                                                Curso_Id = (lstBusqueda.SelectedItem as Curso).Id });
            
            this.lstCursosSeleccionados.DataSource = null;
            this.lstCursosSeleccionados.DataSource = _lstAlumnoCursoSeleccionados;
            this.lstCursosSeleccionados.SelectedIndex = 0;
        }
        private void btnBajaInscripcion_Click(object sender, EventArgs e)
        {
            _lstAlumnoCursoSeleccionados.Remove(_lstAlumnoCursoSeleccionados.Find(x => x.Curso.Equals(lstCursosSeleccionados.SelectedItem)));
            this.lstCursosSeleccionados.DataSource = null;
            this.lstCursosSeleccionados.DataSource = _lstAlumnoCursoSeleccionados;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var _lsTemp = new List<AlumnoCurso>();
                foreach (var item in _lstAlumnoCursoSeleccionados)
                {
                    if (UtilityHelper.GetDbContext().Entry(item).State == EntityState.Detached)
                    {
                        _lsTemp.Add(item);
                    }
                }

                if (_lsTemp.Count > 0)
                {
                    _alumnoCursoRepo.AddRange(_lsTemp);
                }

                foreach (var item in _lsTemp)
                {
                    _lstAlumnoCursoSeleccionados.Remove(item);
                }

                _alumnoCursoRepo.SaveRange(_lstAlumnoCursoSeleccionados);

                MessageBox.Show("Se guardaron los datos correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        #endregion

        #region Metodos
       
        private void SetearDatosAlumno()
        {
            if (AlumnoSeleccionado == null) return;
            this.lblDatosAlumno.Text = AlumnoSeleccionado.ToString();
        }
        private void SetearTextBox()
        {
            if (_curso == null) return;
            this.txtIdCurso.Text = _curso.Id.ToString();
            this.txtNombreCurso.Text = _curso.NombreCurso.ToString();
            this.txtNombreCurso.Enabled = false;
        }
        private void SetearBoton()
        {
            if (lstBusqueda.Items.Count <= 0)
            {
                this.btnInscripcion.Enabled = false;
            }
            else
            {
                this.btnInscripcion.Enabled = true;
            }
        }
        private void SetearCheckBoxes() {
            if (AlumnoSeleccionado == null) return;
            if (AlumnoSeleccionado.AlumnosCursos.Count <= 0)
            {
                this.chkbAprobado.Enabled = false;
                this.chkbEnCurso.Enabled = false;
            }
            else {
                this.lstCursosSeleccionados.SelectedIndex = 0;
            }
        }
        private void HabilitarCheckBoxes(AlumnoCurso ac) {
            if (ac.EnCurso == true)
            {
                chkbAprobado.Enabled = true;
            }
            else
            {
                this.chkbAprobado.Enabled = false;
                this.chkbAprobado.Checked = false;
            }
            this.chkbEnCurso.Enabled = true;
        }
        
        private void ObtenerCursos()
        {
            _lstCursos = _cursoRepo.GetAll();
            this.lstBusqueda.DataSource = _lstCursos;

        }
        private void InicializarListaCursosSeleccionados()
        {
            if (AlumnoSeleccionado == null) return;
            _lstAlumnoCursoSeleccionados = AlumnoSeleccionado.AlumnosCursos.ToList();
            this.lstCursosSeleccionados.DataSource = null;
            this.lstCursosSeleccionados.DataSource = _lstAlumnoCursoSeleccionados;
        }
        #endregion

        #region Propiedades
        public Alumno AlumnoSeleccionado { get; set; }
        #endregion

        private void lstCursosSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCursosSeleccionados.SelectedItem == null) return;
            _alumnoCurso = _lstAlumnoCursoSeleccionados.Find(x => x.Curso.Equals(lstCursosSeleccionados.SelectedItem));
            chkbAprobado.Checked = _alumnoCurso.Aprobado;
            chkbEnCurso.Checked = _alumnoCurso.EnCurso;
            HabilitarCheckBoxes(_alumnoCurso);
        }

        private void chkbAprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (lstCursosSeleccionados.SelectedItem == null) return;
            _lstAlumnoCursoSeleccionados.Find(x => x.Curso.Equals(lstCursosSeleccionados.SelectedItem)).Aprobado = chkbAprobado.Checked;
           
        }

        private void chkbEnCurso_CheckedChanged(object sender, EventArgs e)
        {
            if (lstCursosSeleccionados.SelectedItem == null) return;
            _lstAlumnoCursoSeleccionados.Find(x => x.Equals(lstCursosSeleccionados.SelectedItem)).EnCurso = chkbEnCurso.Checked;
            _alumnoCurso = _lstAlumnoCursoSeleccionados.Find(x => x.Equals(lstCursosSeleccionados.SelectedItem));
            HabilitarCheckBoxes(_alumnoCurso);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
