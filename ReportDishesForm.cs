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
    public partial class ReportDishesForm : Form
    {
        public ReportDishesForm()
        {
            InitializeComponent();
        }

        private void ReportDishesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportDishesDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.DataTableTableAdapter.Fill(this.ReportDishesDataSet.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
