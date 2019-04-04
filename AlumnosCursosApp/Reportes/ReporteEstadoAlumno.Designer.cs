namespace AlumnosCursosApp.Reportes
{
    partial class ReporteEstadoAlumno
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
            this.rvEstadoAlumno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvEstadoAlumno
            // 
            this.rvEstadoAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvEstadoAlumno.LocalReport.ReportEmbeddedResource = "AlumnosCursosApp.Reportes.rptEstadoAlumno.rdlc";
            this.rvEstadoAlumno.Location = new System.Drawing.Point(0, 0);
            this.rvEstadoAlumno.Name = "rvEstadoAlumno";
            this.rvEstadoAlumno.Size = new System.Drawing.Size(800, 450);
            this.rvEstadoAlumno.TabIndex = 0;
            // 
            // ReporteEstadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvEstadoAlumno);
            this.Name = "ReporteEstadoAlumno";
            this.Text = "ReporteEstadoAlumno";
            this.Load += new System.EventHandler(this.ReporteEstadoAlumno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEstadoAlumno;
    }
}