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
    public partial class ReportOrdersForm : Form
    {
        public ReportOrdersForm()
        {
            InitializeComponent();
        }

        private void ReportOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportOrdersDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.ReportOrdersDataSet.Orders);

            this.reportViewer1.RefreshReport();
        }
    }
}
