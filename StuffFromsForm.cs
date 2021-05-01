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
    public partial class StuffFromsForm : Form
    {
        public StuffFromsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unitsBtn_Click(object sender, EventArgs e)
        {
            UnitsForm f = new UnitsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void dishesBtn_Click(object sender, EventArgs e)
        {
            DishesForm f = new DishesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            OrdersForm f = new OrdersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void providersBtn_Click(object sender, EventArgs e)
        {
            ProductProvidersForm f = new ProductProvidersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
