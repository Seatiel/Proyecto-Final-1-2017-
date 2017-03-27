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
    public partial class rpFacturas : Form
    {
        public rpFacturas()
        {
            InitializeComponent();
        }

        private void rpFacturas_Load(object sender, EventArgs e)
        {
            this.FacturasreportViewer.RefreshReport();
            FacturasreportViewer.Reset();
            FacturasreportViewer.ProcessingMode = ProcessingMode.Local;
            FacturasreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Dropbox\Proyecto de Aplicada (1-2017)\ProyectoFinalLavanderia\ProyectoFinalLavanderia\UI\Reportes\FacturasReport.rdlc";
            ReportDataSource source = new ReportDataSource("LavanderiaDataSet", BLL.FacturasBLL.ListarTodo());
            FacturasreportViewer.LocalReport.DataSources.Add(source);
            this.FacturasreportViewer.RefreshReport();
        }
    }
}
