using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using kursologV2.ReportEmployeesDataSetTableAdapters;

namespace kursologV2
{
    public partial class ReportEmployeesForm : Form
    {
        public ReportEmployeesForm()
        {
            InitializeComponent();
        }

        private void ReportEmployeesForm_Load(object sender, EventArgs e)
        {
            var dataTable = new ReportEmployeesDataSet.DataTable1DataTable();
            var tableAdapter = new DataTable1TableAdapter();
            tableAdapter.Fill(dataTable);
            var rds = new ReportDataSource("ReportEmployeesDataSet", dataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
