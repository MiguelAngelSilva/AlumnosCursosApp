namespace AlumnosCursosApp
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnABMCursos = new System.Windows.Forms.Button();
            this.btnABMAlumnos = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotonera.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotonera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBotonera.Controls.Add(this.btnSalir);
            this.pnlBotonera.Controls.Add(this.btnABMCursos);
            this.pnlBotonera.Controls.Add(this.btnABMAlumnos);
            this.pnlBotonera.Controls.Add(this.pnlTitulo);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(238, 535);
            this.pnlBotonera.TabIndex = 4;
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
            this.btnSalir.Location = new System.Drawing.Point(0, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(238, 40);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnABMCursos
            // 
            this.btnABMCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMCursos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnABMCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnABMCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMCursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMCursos.ForeColor = System.Drawing.Color.Gray;
            this.btnABMCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMCursos.Location = new System.Drawing.Point(0, 140);
            this.btnABMCursos.Name = "btnABMCursos";
            this.btnABMCursos.Size = new System.Drawing.Size(238, 40);
            this.btnABMCursos.TabIndex = 34;
            this.btnABMCursos.Text = "ABM Cursos";
            this.btnABMCursos.UseVisualStyleBackColor = true;
            this.btnABMCursos.Click += new System.EventHandler(this.btnABMCursos_Click);
            // 
            // btnABMAlumnos
            // 
            this.btnABMAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnABMAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnABMAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMAlumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMAlumnos.ForeColor = System.Drawing.Color.Gray;
            this.btnABMAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnABMAlumnos.Location = new System.Drawing.Point(0, 100);
            this.btnABMAlumnos.Name = "btnABMAlumnos";
            this.btnABMAlumnos.Size = new System.Drawing.Size(238, 40);
            this.btnABMAlumnos.TabIndex = 33;
            this.btnABMAlumnos.Text = "ABM Alumnos";
            this.btnABMAlumnos.UseVisualStyleBackColor = true;
            this.btnABMAlumnos.Click += new System.EventHandler(this.btnABMAlumnos_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(238, 100);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "App de Alumnos y Cursos";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 535);
            this.Controls.Add(this.pnlBotonera);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBotonera.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnABMCursos;
        private System.Windows.Forms.Button btnABMAlumnos;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}



