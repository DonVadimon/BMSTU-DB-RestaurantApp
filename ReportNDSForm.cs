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
    public partial class ReportNDSForm : Form
    {
        public ReportNDSForm()
        {
            InitializeComponent();
        }

        private void ReportNDSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.DishesTableAdapter.Fill(this.suetaDataSet.Dishes);

            this.reportViewer1.RefreshReport();
        }
    }
}
