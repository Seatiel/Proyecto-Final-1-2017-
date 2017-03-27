namespace ProyectoFinalLavanderia.UI.Reportes
{
    partial class rpFacturas
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
            this.FacturasreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturasreportViewer
            // 
            this.FacturasreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturasreportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturasreportViewer.Name = "FacturasreportViewer";
            this.FacturasreportViewer.Size = new System.Drawing.Size(736, 483);
            this.FacturasreportViewer.TabIndex = 0;
            // 
            // rpFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 483);
            this.Controls.Add(this.FacturasreportViewer);
            this.Name = "rpFacturas";
            this.Text = "rpFacturas";
            this.Load += new System.EventHandler(this.rpFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FacturasreportViewer;
    }
}