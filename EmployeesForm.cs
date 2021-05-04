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
    public partial class EmployeesForm : Form, ICRUDForm
    {
        private static class EmployeeModel
        {
            public static int id { get; set; }
            public static string fullName { get; set; }
            public static string phone { get; set; }
            public static int positionId { get; set; }

            public static void reset()
            {
                id = -1;
                fullName = "";
                phone = "";
                positionId = -1;
            }
        }

        public EmployeesForm()
        {
            InitializeComponent();
            clearInputs();
            EmployeeModel.reset();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.suetaDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.suetaDataSet.Employees);
        }

        public void updateView()
        {
            employeesTableAdapter.Fill(suetaDataSet.Employees);
            employeesBindingSource.ResetBindings(false);
            employeesDataGridView.Update();
        }

        public void insertRow()
        {
            employeesTableAdapter.Insert(fullNameTextBox.Text, phoneTextBox.Text, positionsTableAdapter.GetData()
                .FirstOrDefault(p => p.Position == positionComboBox.Text).PositionId);
        }

        public void deleteRow()
        {
            employeesTableAdapter.Delete(EmployeeModel.id, EmployeeModel.fullName, EmployeeModel.phone, EmployeeModel.positionId);
        }

        public void updateRow()
        {
            employeesTableAdapter.Update(fullNameTextBox.Text, phoneTextBox.Text, positionsTableAdapter.GetData()
                .FirstOrDefault(p => p.Position == positionComboBox.Text).PositionId,
                EmployeeModel.id, EmployeeModel.fullName, EmployeeModel.phone, EmployeeModel.positionId);
        }

        public void updateInputs()
        {
            fullNameTextBox.Text = EmployeeModel.fullName;
            phoneTextBox.Text = EmployeeModel.phone;
            positionComboBox.SelectedIndex = positionComboBox.FindStringExact(positionsTableAdapter.GetData()
                .FirstOrDefault(p => p.PositionId == EmployeeModel.positionId).Position);
        }

        public void clearInputs()
        {
            fullNameTextBox.Text = "";
            phoneTextBox.Text = "";
            positionComboBox.SelectedIndex = -1;
        }

        public bool isIncorrectModel()
        {
            return EmployeeModel.id < 0 || EmployeeModel.fullName == "" || EmployeeModel.phone == "" || EmployeeModel.positionId < 0;
        }

        public bool isIncorrectInputs()
        {
            return fullNameTextBox.Text == "" || phoneTextBox.Text == "" || positionComboBox.SelectedIndex < 0;
        }

        private void employeesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmployeeModel.id = Convert.ToInt32(employeesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            EmployeeModel.fullName = employeesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            EmployeeModel.phone = employeesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmployeeModel.positionId = Convert.ToInt32(employeesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            updateInputs();
        }

        private void EmployeesForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            EmployeeModel.reset();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                insertRow();
                updateView();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel() || isIncorrectInputs())
            {
                MessageBox.Show("Выберите строку и введите новые значения");
            }
            else
            {
                updateRow();
                updateView();
                EmployeeModel.reset();
                clearInputs();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel() || isIncorrectInputs())
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                deleteRow();
                updateView();
                EmployeeModel.reset();
                clearInputs();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeesListReportBtn_Click(object sender, EventArgs e)
        {
            ReportEmployeesForm f = new ReportEmployeesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
