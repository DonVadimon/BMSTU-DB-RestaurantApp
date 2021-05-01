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
    public partial class AdminFormsFrom : Form
    {
        public AdminFormsFrom()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void positionsBtn_Click(object sender, EventArgs e)
        {
            PositionsForm f = new PositionsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesForm f = new EmployeesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
