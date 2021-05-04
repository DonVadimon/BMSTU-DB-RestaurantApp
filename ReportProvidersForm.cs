using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursologV2
{
    public partial class ReportProvidersForm : Form
    {
        public ReportProvidersForm()
        {
            InitializeComponent();
        }

        private void ReportProvidersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportProvidersDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.DataTableTableAdapter.Fill(this.ReportProvidersDataSet.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
