namespace ProyectoFinalLavanderia.UI.Reportes
{
    partial class rpServicios
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
            this.ServiciosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ServiciosreportViewer
            // 
            this.ServiciosreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiciosreportViewer.Location = new System.Drawing.Point(0, 0);
            this.ServiciosreportViewer.Name = "ServiciosreportViewer";
            this.ServiciosreportViewer.Size = new System.Drawing.Size(690, 471);
            this.ServiciosreportViewer.TabIndex = 0;
            // 
            // rpServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 471);
            this.Controls.Add(this.ServiciosreportViewer);
            this.Name = "rpServicios";
            this.Text = "rpServicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rpServicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ServiciosreportViewer;
    }
}