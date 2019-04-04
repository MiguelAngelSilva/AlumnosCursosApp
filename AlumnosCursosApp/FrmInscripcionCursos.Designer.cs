namespace AlumnosCursosApp
{
    partial class FrmInscripcionCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlCursosSeleccionados = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbEnCurso = new System.Windows.Forms.CheckBox();
            this.chkbAprobado = new System.Windows.Forms.CheckBox();
            this.lstCursosSeleccionados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlInscripcionBaja = new System.Windows.Forms.Panel();
            this.btnBajaInscripcion = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.pnlBusquedaDetalle = new System.Windows.Forms.Panel();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBusqueda = new System.Windows.Forms.ListBox();
            this.txtBuscqueda = new System.Windows.Forms.TextBox();
            this.pnlDatosAlumno = new System.Windows.Forms.Panel();
            this.lblDatosAlumno = new System.Windows.Forms.Label();
            this.pnlBotonera.SuspendLayout();
            this.pnlCursosSeleccionados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInscripcionBaja.SuspendLayout();
            this.pnlBusquedaDetalle.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.pnlDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotonera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBotonera.Controls.Add(this.btnSalir);
            this.pnlBotonera.Controls.Add(this.btnGuardar);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(197, 465);
            this.pnlBotonera.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Gray;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 40);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gray;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(197, 40);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlCursosSeleccionados
            // 
            this.pnlCursosSeleccionados.Controls.Add(this.groupBox1);
            this.pnlCursosSeleccionados.Controls.Add(this.pnlInscripcionBaja);
            this.pnlCursosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCursosSeleccionados.Location = new System.Drawing.Point(741, 57);
            this.pnlCursosSeleccionados.Name = "pnlCursosSeleccionados";
            this.pnlCursosSeleccionados.Size = new System.Drawing.Size(349, 408);
            this.pnlCursosSeleccionados.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbEnCurso);
            this.groupBox1.Controls.Add(this.chkbAprobado);
            this.groupBox1.Controls.Add(this.lstCursosSeleccionados);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(65, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 393);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chkbEnCurso
            // 
            this.chkbEnCurso.AutoSize = true;
            this.chkbEnCurso.Location = new System.Drawing.Point(7, 370);
            this.chkbEnCurso.Name = "chkbEnCurso";
            this.chkbEnCurso.Size = new System.Drawing.Size(69, 17);
            this.chkbEnCurso.TabIndex = 8;
            this.chkbEnCurso.Text = "En Curso";
            this.chkbEnCurso.UseVisualStyleBackColor = true;
            this.chkbEnCurso.CheckedChanged += new System.EventHandler(this.chkbEnCurso_CheckedChanged);
            // 
            // chkbAprobado
            // 
            this.chkbAprobado.AutoSize = true;
            this.chkbAprobado.Location = new System.Drawing.Point(7, 347);
            this.chkbAprobado.Name = "chkbAprobado";
            this.chkbAprobado.Size = new System.Drawing.Size(72, 17);
            this.chkbAprobado.TabIndex = 7;
            this.chkbAprobado.Text = "Aprobado";
            this.chkbAprobado.UseVisualStyleBackColor = true;
            this.chkbAprobado.CheckedChanged += new System.EventHandler(this.chkbAprobado_CheckedChanged);
            // 
            // lstCursosSeleccionados
            // 
            this.lstCursosSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCursosSeleccionados.FormattingEnabled = true;
            this.lstCursosSeleccionados.Location = new System.Drawing.Point(6, 34);
            this.lstCursosSeleccionados.Name = "lstCursosSeleccionados";
            this.lstCursosSeleccionados.Size = new System.Drawing.Size(263, 301);
            this.lstCursosSeleccionados.TabIndex = 6;
            this.lstCursosSeleccionados.SelectedIndexChanged += new System.EventHandler(this.lstCursosSeleccionados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cursos Seleccionados:";
            // 
            // pnlInscripcionBaja
            // 
            this.pnlInscripcionBaja.Controls.Add(this.btnBajaInscripcion);
            this.pnlInscripcionBaja.Controls.Add(this.btnInscripcion);
            this.pnlInscripcionBaja.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInscripcionBaja.Location = new System.Drawing.Point(0, 0);
            this.pnlInscripcionBaja.Name = "pnlInscripcionBaja";
            this.pnlInscripcionBaja.Size = new System.Drawing.Size(59, 408);
            this.pnlInscripcionBaja.TabIndex = 5;
            // 
            // btnBajaInscripcion
            // 
            this.btnBajaInscripcion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBajaInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBajaInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaInscripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaInscripcion.ForeColor = System.Drawing.Color.Gray;
            this.btnBajaInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaInscripcion.Location = new System.Drawing.Point(6, 118);
            this.btnBajaInscripcion.Name = "btnBajaInscripcion";
            this.btnBajaInscripcion.Size = new System.Drawing.Size(46, 40);
            this.btnBajaInscripcion.TabIndex = 42;
            this.btnBajaInscripcion.Text = "<<";
            this.btnBajaInscripcion.UseVisualStyleBackColor = true;
            this.btnBajaInscripcion.Click += new System.EventHandler(this.btnBajaInscripcion_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcion.ForeColor = System.Drawing.Color.Gray;
            this.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.Location = new System.Drawing.Point(6, 72);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(46, 40);
            this.btnInscripcion.TabIndex = 41;
            this.btnInscripcion.Text = ">>";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // pnlBusquedaDetalle
            // 
            this.pnlBusquedaDetalle.Controls.Add(this.pnlDetalle);
            this.pnlBusquedaDetalle.Controls.Add(this.pnlBusqueda);
            this.pnlBusquedaDetalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBusquedaDetalle.Location = new System.Drawing.Point(197, 57);
            this.pnlBusquedaDetalle.Name = "pnlBusquedaDetalle";
            this.pnlBusquedaDetalle.Size = new System.Drawing.Size(544, 408);
            this.pnlBusquedaDetalle.TabIndex = 11;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.gbDetalle);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 231);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(544, 177);
            this.pnlDetalle.TabIndex = 14;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtNombreCurso);
            this.gbDetalle.Controls.Add(this.txtIdCurso);
            this.gbDetalle.Controls.Add(this.label8);
            this.gbDetalle.Controls.Add(this.label9);
            this.gbDetalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalle.ForeColor = System.Drawing.Color.Gray;
            this.gbDetalle.Location = new System.Drawing.Point(9, 6);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(527, 159);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(414, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "(Max. 50 Caracteres)";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCurso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCurso.Location = new System.Drawing.Point(154, 81);
            this.txtNombreCurso.MaxLength = 50;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(259, 22);
            this.txtNombreCurso.TabIndex = 39;
            this.txtNombreCurso.Tag = "Nombre de Curso";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.Location = new System.Drawing.Point(154, 53);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(259, 22);
            this.txtIdCurso.TabIndex = 38;
            this.txtIdCurso.Tag = "Razón Social";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(1, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre de Curso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(117, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "ID:";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.gbBusqueda);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(544, 231);
            this.pnlBusqueda.TabIndex = 13;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.lstBusqueda);
            this.gbBusqueda.Controls.Add(this.txtBuscqueda);
            this.gbBusqueda.Location = new System.Drawing.Point(6, 6);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(527, 219);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar Datos:";
            // 
            // lstBusqueda
            // 
            this.lstBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBusqueda.FormattingEnabled = true;
            this.lstBusqueda.Location = new System.Drawing.Point(136, 40);
            this.lstBusqueda.Name = "lstBusqueda";
            this.lstBusqueda.Size = new System.Drawing.Size(383, 171);
            this.lstBusqueda.TabIndex = 1;
            this.lstBusqueda.SelectedIndexChanged += new System.EventHandler(this.lstBusqueda_SelectedIndexChanged);
            // 
            // txtBuscqueda
            // 
            this.txtBuscqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscqueda.Location = new System.Drawing.Point(136, 18);
            this.txtBuscqueda.Name = "txtBuscqueda";
            this.txtBuscqueda.Size = new System.Drawing.Size(383, 20);
            this.txtBuscqueda.TabIndex = 0;
            this.txtBuscqueda.TextChanged += new System.EventHandler(this.txtBuscqueda_TextChanged);
            // 
            // pnlDatosAlumno
            // 
            this.pnlDatosAlumno.Controls.Add(this.lblDatosAlumno);
            this.pnlDatosAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosAlumno.Location = new System.Drawing.Point(197, 0);
            this.pnlDatosAlumno.Name = "pnlDatosAlumno";
            this.pnlDatosAlumno.Size = new System.Drawing.Size(893, 57);
            this.pnlDatosAlumno.TabIndex = 10;
            // 
            // lblDatosAlumno
            // 
            this.lblDatosAlumno.AutoSize = true;
            this.lblDatosAlumno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAlumno.ForeColor = System.Drawing.Color.Gray;
            this.lblDatosAlumno.Location = new System.Drawing.Point(14, 9);
            this.lblDatosAlumno.Name = "lblDatosAlumno";
            this.lblDatosAlumno.Size = new System.Drawing.Size(183, 30);
            this.lblDatosAlumno.TabIndex = 3;
            this.lblDatosAlumno.Text = "Datos ALumno ...";
            // 
            // FrmInscripcionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 465);
            this.Controls.Add(this.pnlCursosSeleccionados);
            this.Controls.Add(this.pnlBusquedaDetalle);
            this.Controls.Add(this.pnlDatosAlumno);
            this.Controls.Add(this.pnlBotonera);
            this.Name = "FrmInscripcionCursos";
            this.Text = "Inscripcion de Cursos";
            this.Load += new System.EventHandler(this.FrmInscripcionCursos_Load);
            this.pnlBotonera.ResumeLayout(false);
            this.pnlCursosSeleccionados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInscripcionBaja.ResumeLayout(false);
            this.pnlBusquedaDetalle.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.pnlDatosAlumno.ResumeLayout(false);
            this.pnlDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlCursosSeleccionados;
        private System.Windows.Forms.Panel pnlInscripcionBaja;
        private System.Windows.Forms.Button btnBajaInscripcion;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Panel pnlBusquedaDetalle;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBusqueda;
        private System.Windows.Forms.TextBox txtBuscqueda;
        private System.Windows.Forms.Panel pnlDatosAlumno;
        private System.Windows.Forms.Label lblDatosAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCursosSeleccionados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbEnCurso;
        private System.Windows.Forms.CheckBox chkbAprobado;
    }
}