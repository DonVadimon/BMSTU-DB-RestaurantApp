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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeesListBtn_Click(object sender, EventArgs e)
        {
            ReportEmployeesForm f = new ReportEmployeesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void positionsListBtn_Click(object sender, EventArgs e)
        {
            ReportPositionsForm f = new ReportPositionsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void dishesListBtn_Click(object sender, EventArgs e)
        {
            ReportDishesForm f = new ReportDishesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
