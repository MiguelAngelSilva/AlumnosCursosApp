namespace AlumnosCursosApp
{
    partial class FrmAlumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBusqueda = new System.Windows.Forms.ListBox();
            this.txtBuscqueda = new System.Windows.Forms.TextBox();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlBotonera.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotonera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBotonera.Controls.Add(this.btnSalir);
            this.pnlBotonera.Controls.Add(this.btnCursos);
            this.pnlBotonera.Controls.Add(this.btnReporte);
            this.pnlBotonera.Controls.Add(this.btnGuardar);
            this.pnlBotonera.Controls.Add(this.btnEliminar);
            this.pnlBotonera.Controls.Add(this.btnEditar);
            this.pnlBotonera.Controls.Add(this.btnCrear);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(238, 362);
            this.pnlBotonera.TabIndex = 5;
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
            this.btnSalir.Location = new System.Drawing.Point(0, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(238, 40);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.Gray;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(0, 200);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(238, 40);
            this.btnCursos.TabIndex = 42;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Gray;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 160);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(238, 40);
            this.btnReporte.TabIndex = 39;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(0, 120);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(238, 40);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(238, 40);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Gray;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 40);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(238, 40);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Gray;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(238, 40);
            this.btnCrear.TabIndex = 33;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.gbBusqueda);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(238, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(604, 190);
            this.pnlBusqueda.TabIndex = 6;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.lstBusqueda);
            this.gbBusqueda.Controls.Add(this.txtBuscqueda);
            this.gbBusqueda.Location = new System.Drawing.Point(9, 3);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(586, 178);
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
            this.lstBusqueda.Size = new System.Drawing.Size(444, 132);
            this.lstBusqueda.TabIndex = 1;
            this.lstBusqueda.SelectedIndexChanged += new System.EventHandler(this.lstBusqueda_SelectedIndexChanged);
            // 
            // txtBuscqueda
            // 
            this.txtBuscqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscqueda.Location = new System.Drawing.Point(136, 18);
            this.txtBuscqueda.Name = "txtBuscqueda";
            this.txtBuscqueda.Size = new System.Drawing.Size(444, 20);
            this.txtBuscqueda.TabIndex = 0;
            this.txtBuscqueda.TextChanged += new System.EventHandler(this.txtBuscqueda_TextChanged);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.gbDetalle);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Location = new System.Drawing.Point(238, 190);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(604, 172);
            this.pnlDetalle.TabIndex = 7;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.txtApellido);
            this.gbDetalle.Controls.Add(this.label3);
            this.gbDetalle.Controls.Add(this.txtNombres);
            this.gbDetalle.Controls.Add(this.txtDNI);
            this.gbDetalle.Controls.Add(this.label8);
            this.gbDetalle.Controls.Add(this.label9);
            this.gbDetalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalle.Location = new System.Drawing.Point(9, 7);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(586, 158);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(190, 21);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(259, 22);
            this.txtApellido.TabIndex = 39;
            this.txtApellido.Tag = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(105, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Apellido:";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Location = new System.Drawing.Point(190, 48);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(259, 22);
            this.txtNombres.TabIndex = 35;
            this.txtNombres.Tag = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Location = new System.Drawing.Point(190, 76);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(259, 22);
            this.txtDNI.TabIndex = 34;
            this.txtDNI.Tag = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(88, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre(s):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(140, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "DNI:";
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 362);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlBotonera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM ALumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            this.pnlBotonera.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBusqueda;
        private System.Windows.Forms.TextBox txtBuscqueda;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnReporte;
    }
}

