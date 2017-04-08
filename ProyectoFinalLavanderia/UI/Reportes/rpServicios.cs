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
    public partial class rpServicios : Form
    {
        object DataSource;

        public rpServicios(object dataSource)
        {
            this.DataSource = dataSource;
            InitializeComponent();
        }

        private void rpServicios_Load(object sender, EventArgs e)
        {
            this.ServiciosreportViewer.RefreshReport();
            ServiciosreportViewer.Reset();
            ServiciosreportViewer.ProcessingMode = ProcessingMode.Local;
            ServiciosreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Dropbox\Proyecto de Aplicada (1-2017)\ProyectoFinalLavanderia\ProyectoFinalLavanderia\UI\Reportes\ServiciosReport.rdlc";
            ReportDataSource source = new ReportDataSource("LavanderiaDataSet", DataSource);
            ServiciosreportViewer.LocalReport.DataSources.Add(source);
            this.ServiciosreportViewer.RefreshReport();
        }
    }
}
