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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog(this);
            if (f.isLoggedIn)
            {
                Show();
            }
            else
            {
                Close();
            }
        }

        private void formsBtn_Click(object sender, EventArgs e)
        {
            FormsForm f = new FormsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            InfoFrom f = new InfoFrom();
            Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm f = new ReportsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
