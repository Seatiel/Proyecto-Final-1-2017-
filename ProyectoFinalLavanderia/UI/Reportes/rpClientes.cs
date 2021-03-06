﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalLavanderia.UI.Reportes
{
    public partial class rpClientes : Form
    {

        object DataSource;

        public rpClientes(object dataSource)
        {
            this.DataSource = dataSource;
            InitializeComponent();
        }

        private void rpClientes_Load(object sender, EventArgs e)
        {
            this.ClientesreportViewer.RefreshReport();
            ClientesreportViewer.Reset();
            ClientesreportViewer.ProcessingMode = ProcessingMode.Local;
            ClientesreportViewer.LocalReport.ReportPath = @"C:\Users\Seatiel\Dropbox\Proyecto de Aplicada (1-2017)\ProyectoFinalLavanderia\ProyectoFinalLavanderia\UI\Reportes\ClientesReport.rdlc";
            ReportDataSource source = new ReportDataSource("LavanderiaDataSet", DataSource);
            ClientesreportViewer.LocalReport.DataSources.Add(source);
            this.ClientesreportViewer.RefreshReport();
        }
    }
}
