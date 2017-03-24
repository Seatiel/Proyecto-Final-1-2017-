namespace ProyectoFinalLavanderia.UI.Consultas
{
    partial class cClientes
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
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.ValidarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FechaCreaciondateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrartextBox.Location = new System.Drawing.Point(80, 43);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(359, 24);
            this.FiltrartextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(598, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(112, 39);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(445, 41);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(147, 26);
            this.FiltrarcomboBox.TabIndex = 3;
            this.FiltrarcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrarcomboBox_SelectedIndexChanged);
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(15, 148);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.RowTemplate.Height = 24;
            this.ClientesdataGridView.Size = new System.Drawing.Size(714, 252);
            this.ClientesdataGridView.TabIndex = 4;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimirbutton.Location = new System.Drawing.Point(15, 416);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(112, 39);
            this.Imprimirbutton.TabIndex = 5;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // ValidarerrorProvider
            // 
            this.ValidarerrorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Creacion:";
            // 
            // FechaCreaciondateTimePicker
            // 
            this.FechaCreaciondateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaCreaciondateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreaciondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCreaciondateTimePicker.Location = new System.Drawing.Point(190, 85);
            this.FechaCreaciondateTimePicker.Name = "FechaCreaciondateTimePicker";
            this.FechaCreaciondateTimePicker.Size = new System.Drawing.Size(141, 24);
            this.FechaCreaciondateTimePicker.TabIndex = 7;
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 471);
            this.Controls.Add(this.FechaCreaciondateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ClientesdataGridView);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrartextBox);
            this.Name = "cClientes";
            this.Text = "cClientes";
            this.Load += new System.EventHandler(this.cClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.ErrorProvider ValidarerrorProvider;
        private System.Windows.Forms.DateTimePicker FechaCreaciondateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}