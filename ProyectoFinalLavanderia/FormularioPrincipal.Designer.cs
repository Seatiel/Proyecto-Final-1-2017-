namespace ProyectoFinalLavanderia
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTiposDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsgistrosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ayudaToolStripMenuItem.Text = "Archivos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosClientesToolStripMenuItem,
            this.registrosFacturasToolStripMenuItem,
            this.registrosServiciosToolStripMenuItem,
            this.registroDeTiposDeUsuariosToolStripMenuItem,
            this.rsgistrosUsuariosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrosClientesToolStripMenuItem
            // 
            this.registrosClientesToolStripMenuItem.Name = "registrosClientesToolStripMenuItem";
            this.registrosClientesToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.registrosClientesToolStripMenuItem.Text = "&Registros &Clientes";
            this.registrosClientesToolStripMenuItem.Click += new System.EventHandler(this.registrosClientesToolStripMenuItem_Click);
            // 
            // registrosFacturasToolStripMenuItem
            // 
            this.registrosFacturasToolStripMenuItem.Name = "registrosFacturasToolStripMenuItem";
            this.registrosFacturasToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.registrosFacturasToolStripMenuItem.Text = "Registros &Facturas";
            this.registrosFacturasToolStripMenuItem.Click += new System.EventHandler(this.registrosFacturasToolStripMenuItem_Click);
            // 
            // registrosServiciosToolStripMenuItem
            // 
            this.registrosServiciosToolStripMenuItem.Name = "registrosServiciosToolStripMenuItem";
            this.registrosServiciosToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.registrosServiciosToolStripMenuItem.Text = "Registros &Servicios";
            // 
            // registroDeTiposDeUsuariosToolStripMenuItem
            // 
            this.registroDeTiposDeUsuariosToolStripMenuItem.Name = "registroDeTiposDeUsuariosToolStripMenuItem";
            this.registroDeTiposDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.registroDeTiposDeUsuariosToolStripMenuItem.Text = "Registros &Tipos de Usuarios";
            // 
            // rsgistrosUsuariosToolStripMenuItem
            // 
            this.rsgistrosUsuariosToolStripMenuItem.Name = "rsgistrosUsuariosToolStripMenuItem";
            this.rsgistrosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.rsgistrosUsuariosToolStripMenuItem.Text = "Registros &Usuarios";
            this.rsgistrosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.rsgistrosUsuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consutasClientesToolStripMenuItem,
            this.consultasFacturasToolStripMenuItem,
            this.consultasServiciosToolStripMenuItem,
            this.consultasUsuariosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consutasClientesToolStripMenuItem
            // 
            this.consutasClientesToolStripMenuItem.Name = "consutasClientesToolStripMenuItem";
            this.consutasClientesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.consutasClientesToolStripMenuItem.Text = "Consultas &Clientes";
            this.consutasClientesToolStripMenuItem.Click += new System.EventHandler(this.consultasClientesToolStripMenuItem_Click);
            // 
            // consultasFacturasToolStripMenuItem
            // 
            this.consultasFacturasToolStripMenuItem.Name = "consultasFacturasToolStripMenuItem";
            this.consultasFacturasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.consultasFacturasToolStripMenuItem.Text = "Consultas &Facturas";
            this.consultasFacturasToolStripMenuItem.Click += new System.EventHandler(this.consultasFacturasToolStripMenuItem_Click);
            // 
            // consultasServiciosToolStripMenuItem
            // 
            this.consultasServiciosToolStripMenuItem.Name = "consultasServiciosToolStripMenuItem";
            this.consultasServiciosToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.consultasServiciosToolStripMenuItem.Text = "Consultas &Servicios";
            this.consultasServiciosToolStripMenuItem.Click += new System.EventHandler(this.consultasServiciosToolStripMenuItem_Click);
            // 
            // consultasUsuariosToolStripMenuItem
            // 
            this.consultasUsuariosToolStripMenuItem.Name = "consultasUsuariosToolStripMenuItem";
            this.consultasUsuariosToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.consultasUsuariosToolStripMenuItem.Text = "Consultas &Usuarios";
            this.consultasUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultasUsuariosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1400, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 146);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lavanderia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1380, 900);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hecho por: Seatiel Ygnacio Rosario (2014-0597)";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsgistrosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consutasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTiposDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasFacturasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

