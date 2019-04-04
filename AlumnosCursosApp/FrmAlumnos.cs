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
using AlumnosCursosDAL.EF;


namespace AlumnosCursosApp
{
    public partial class FrmAlumnos : Form
    {
        Alumno _alumno;
         
        AlumnoRepo _alumnoRepo = new AlumnoRepo(UtilityHelper.GetDbContext());
        List<Alumno> _lstAlumnos = new List<Alumno>();
        Accion _accion;

        public FrmAlumnos()
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
                _alumno = new Alumno();
                this.txtNombres.Enabled = true;
                this.txtApellido.Enabled = true;
                this.txtDNI.Enabled = true;
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
                this.txtNombres.Enabled = true;
                this.txtApellido.Enabled = true;
                this.txtDNI.Enabled = true;
               
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
            if (_alumno == null) return;
            if (MessageBox.Show("Se va a eliminar un curso.\nConfirmar Acción.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _alumnoRepo.Delete(_alumno);
            Utilities.UtilityHelper.ClearForm(this);
            ObtenerAlumnos();
            SetearTextBox();
        }
        private void txtBuscqueda_TextChanged(object sender, EventArgs e)
        {
            this.lstBusqueda.DataSource = _lstAlumnos.Where<Alumno>(a => a.ToString().ToUpper().Contains(this.txtBuscqueda.Text.ToUpper())).ToList();

        }
        private void lstBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            _alumno = lstBusqueda.SelectedItem as Alumno;
            SetearTextBox();
            HabilitarBotones();

        }
        #endregion

        #region Validaciones
        private bool ValidarDatos()
        {
            
            return UtilityHelper.ValidarDatos(this);
        }
        #endregion
        #region Metodos
        private void InicializarBotonera()
        {
            if (lstBusqueda.Items.Count <= 0)
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;

            }
            else
            {
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;

            }
            this.btnGuardar.Enabled = true;
        }
        private void HabilitarBotones()
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.btnCrear.Enabled = true;
        }
        private void ObtenerAlumnos()
        {
            _lstAlumnos = _alumnoRepo.GetAll();
            this.lstBusqueda.DataSource = _lstAlumnos;
        }
        private void SetearTextBox()
        {
            if (_alumno == null) return;
            this.txtNombres.Text = _alumno.Nombre;
            this.txtApellido.Text = _alumno.Apellido;
            this.txtDNI.Text = _alumno.Dni;
        }
        private void SaveOrUpdate(Accion a)
        {
            try
            {
                if (_alumno == null)
                    return;
                _alumno.Nombre = this.txtNombres.Text;
                _alumno.Apellido = this.txtApellido.Text;
                _alumno.Dni = this.txtDNI.Text;
                // falta agregar edad al modelo_alumno.FirstName = this.txtNombres.Text;
                if (!ValidarDatos())
                {
                    return;
                }
                switch (a)
                {
                    case Accion.Crear:
                        _alumnoRepo.Add(_alumno);
                        break;
                    case Accion.Editar:
                        _alumnoRepo.Save(_alumno);
                        break;
                    default:
                        break;
                }

                _alumno = null;
                Utilities.UtilityHelper.ClearForm(this);
                ObtenerAlumnos();
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

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmInscripcionCursos frm = new FrmInscripcionCursos();
            frm.MdiParent = this.MdiParent;
            frm.AlumnoSeleccionado = lstBusqueda.SelectedItem as Alumno;
            frm.Show();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            ObtenerAlumnos();
            SetearTextBox();
            InicializarBotonera();
            _accion = Accion.Empty;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteEstadoAlumno childFormReporteEstado = new ReporteEstadoAlumno();
            childFormReporteEstado.MdiParent = this.MdiParent;
            childFormReporteEstado.AlumnoSeleccionado = lstBusqueda.SelectedItem as Alumno;
            childFormReporteEstado.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
