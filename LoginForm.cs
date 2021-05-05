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
    public partial class LoginForm : Form
    {
        public bool isLoggedIn { get; set; }
        public bool isAdmin { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            isLoggedIn = false;
            isAdmin = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.suetaDataSet.Users);
        }

        private void makeLogin()
        {
            string pass = PasswordTextBox.Text;
            DataRowView selectedGroupItem = UserComboBox.SelectedItem as DataRowView;
            string requiredPass = usersTableAdapter.GetData().First(u => u.Group == UserComboBox.Text).Password;
            if (pass == requiredPass)
            {
                isLoggedIn = true;
                isAdmin = UserComboBox.Text.ToLower() == "admin" ? true : false;
                this.Close();
            }
            else
            {
                isLoggedIn = false;
                MessageBox.Show("Wrong password", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            makeLogin();
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                makeLogin();
            }
        }
    }
}
