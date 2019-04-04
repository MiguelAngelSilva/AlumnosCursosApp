namespace AlumnosCursosApp.Reportes
{
    partial class ReporteAlumnosInscriptosCurso
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
            this.rvAlumnosInscriptosCurso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvAlumnosInscriptosCurso
            // 
            this.rvAlumnosInscriptosCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvAlumnosInscriptosCurso.LocalReport.ReportEmbeddedResource = "AlumnosCursosApp.Reportes.RptAlumnosInscriptosPorCurso.rdlc";
            this.rvAlumnosInscriptosCurso.Location = new System.Drawing.Point(0, 0);
            this.rvAlumnosInscriptosCurso.Name = "rvAlumnosInscriptosCurso";
            this.rvAlumnosInscriptosCurso.ServerReport.BearerToken = null;
            this.rvAlumnosInscriptosCurso.Size = new System.Drawing.Size(800, 450);
            this.rvAlumnosInscriptosCurso.TabIndex = 0;
            // 
            // ReporteAlumnosInscriptosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvAlumnosInscriptosCurso);
            this.Name = "ReporteAlumnosInscriptosCurso";
            this.Text = "Reporte de Alumnos Inscriptos por Curso";
            this.Load += new System.EventHandler(this.ReporteAlumnosCursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAlumnosInscriptosCurso;
    }
}