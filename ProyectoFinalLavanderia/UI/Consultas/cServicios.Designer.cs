namespace ProyectoFinalLavanderia.UI.Consultas
{
    partial class cServicios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cServicios));
            this.ServiciosdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.ValidarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiciosdataGridView
            // 
            this.ServiciosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiciosdataGridView.Location = new System.Drawing.Point(15, 83);
            this.ServiciosdataGridView.Name = "ServiciosdataGridView";
            this.ServiciosdataGridView.RowTemplate.Height = 24;
            this.ServiciosdataGridView.Size = new System.Drawing.Size(714, 252);
            this.ServiciosdataGridView.TabIndex = 12;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(445, 28);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(147, 26);
            this.FiltrarcomboBox.TabIndex = 11;
            this.FiltrarcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrarcomboBox_SelectedIndexChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(598, 15);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(115, 39);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar:";
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrartextBox.Location = new System.Drawing.Point(80, 30);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(359, 24);
            this.FiltrartextBox.TabIndex = 8;
            // 
            // ValidarerrorProvider
            // 
            this.ValidarerrorProvider.ContainerControl = this;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirbutton.Image")));
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(15, 349);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(117, 40);
            this.Imprimirbutton.TabIndex = 16;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // cServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 401);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ServiciosdataGridView);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrartextBox);
            this.Name = "cServicios";
            this.Text = "cServicios";
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ServiciosdataGridView;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.ErrorProvider ValidarerrorProvider;
        private System.Windows.Forms.Button Imprimirbutton;
    }
}