using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia.UI.Reportes
{
    public partial class rpUsuarios : Form
    {
        object DataSource;

        public rpUsuarios(object dataSource)
        {
            this.DataSource = dataSource;
            InitializeComponent();
        }

        private void rpUsuarios_Load(object sender, EventArgs e)
        {
            this.UsuariosreportViewer.RefreshReport();
            UsuariosreportViewer.Reset();
            UsuariosreportViewer.ProcessingMode = ProcessingMode.Local;
            UsuariosreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Dropbox\Proyecto de Aplicada (1-2017)\ProyectoFinalLavanderia\ProyectoFinalLavanderia\UI\Reportes\UsuariosReport.rdlc";
            ReportDataSource source = new ReportDataSource("LavanderiaDataSet", DataSource);
            UsuariosreportViewer.LocalReport.DataSources.Add(source);
            this.UsuariosreportViewer.RefreshReport();
        }
    }
}
