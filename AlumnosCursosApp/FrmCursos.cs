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
using AlumnosCursosApp.Reportes;
namespace AlumnosCursosApp
{
    public partial class FrmCursos : Form
    {
        Curso _curso;
        CursoRepo _cursoRepo = new CursoRepo(UtilityHelper.GetDbContext());
        List<Curso> _lstCursos = new List<Curso>();
        Accion _accion;

        public FrmCursos()
        {
            InitializeComponent();
        }
       

        #region Eventos
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                Utilities.UtilityHelper.ClearForm(this);
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                _curso = new Curso();
                this.txtNombreCurso.Enabled = true;
                _accion = Accion.Crear;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnGuardar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnCrear.Enabled = false;
                this.txtNombreCurso.Enabled = true;
                _accion = Accion.Editar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_accion != Accion.Empty)
                    SaveOrUpdate(_accion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_curso == null) return;
            if (MessageBox.Show("Se va a eliminar un curso.\nConfirmar Acción.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _cursoRepo.Delete(_curso);
            Utilities.UtilityHelper.ClearForm(this);
            ObtenerCursos();
            SetearTextBox();
        }
        private void FrmCursos_Load(object sender, EventArgs e)
        {
            ObtenerCursos();
            SetearTextBox();
            InicializarBotonera();
            _accion = Accion.Empty;
        }
        private void txtBuscqueda_TextChanged(object sender, EventArgs e)
        {
            this.lstBusqueda.DataSource = _lstCursos.Where<Curso>(c => c.ToString().ToUpper().Contains(this.txtBuscqueda.Text.ToUpper())).ToList();

        }
        private void lstBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curso = lstBusqueda.SelectedItem as Curso;
            SetearTextBox();
            HabilitarBotones();

        }
        #endregion
        #region Validaciones
        private bool ValidarDatos() {
            return UtilityHelper.ValidarDatos(this);
        }
        #endregion
        #region Metodos
        private void InicializarBotonera() {
            if (lstBusqueda.Items.Count <= 0)
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                
            }
            else {
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
                
            }
            this.btnGuardar.Enabled = true;
        }
        private void HabilitarBotones() {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnCrear.Enabled = true;
        }
        private void ObtenerCursos() {
            _lstCursos = _cursoRepo.GetAll();
            this.lstBusqueda.DataSource = _lstCursos;
        }
        private void SetearTextBox() {
            if (_curso == null) return;
            this.txtIdCurso.Text = _curso.Id.ToString();
            this.txtNombreCurso.Text = _curso.NombreCurso.ToString();
            this.txtNombreCurso.Enabled = false;
        }
        private void SaveOrUpdate(Accion a) {
            try
            {
                if (_curso == null)
                    return;
                _curso.NombreCurso = this.txtNombreCurso.Text;
                if (!ValidarDatos())
                {
                    return;
                }
                switch (a)
                {
                    case Accion.Crear:
                        _cursoRepo.Add(_curso);
                        break;
                    case Accion.Editar:
                        _cursoRepo.Save(_curso);
                        break;
                    default:
                        break;
                }
               
                _curso = null;
                Utilities.UtilityHelper.ClearForm(this);
                ObtenerCursos();
                SetearTextBox();
                MessageBox.Show("Se guardaron los datos correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }
        #endregion
        #region Enums
        enum Accion
        {
            Empty,
            Crear,
            Editar
        }


        #endregion

        #region Propiedades
        public Alumno AlumnoSeleccionado { get; set; }
        #endregion
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteAlumnosInscriptosCurso childFormReporteInscripcionCursos = new ReporteAlumnosInscriptosCurso();
            childFormReporteInscripcionCursos.MdiParent = this.MdiParent;
            childFormReporteInscripcionCursos.CursoSeleccionado = lstBusqueda.SelectedItem as Curso;
            childFormReporteInscripcionCursos.Show();
        }
    }
}
