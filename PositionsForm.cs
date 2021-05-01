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
    public partial class PositionsForm : Form, ICRUDForm
    {
        private static class PositionModel
        {
            public static int id { get; set; }
            public static string positionName { get; set; }
            public static int salary { get; set; }
            public static void reset()
            {
                id = -1;
                positionName = "";
                salary = -1;
            }
        }

        public PositionsForm()
        {
            InitializeComponent();
            clearInputs();
            PositionModel.reset();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.suetaDataSet.Positions);
        }

        public void updateView()
        {
            positionsTableAdapter.Fill(suetaDataSet.Positions);
            positionsBindingSource.ResetBindings(false);
            positionsDataGridView.Update();
        }

        public void insertRow()
        {
            positionsTableAdapter.Insert(positionNameTextBox.Text, salaryNumericUpDown.Value);
        }

        public void deleteRow()
        {
            positionsTableAdapter.Delete(PositionModel.id, PositionModel.positionName, PositionModel.salary);
        }

        public void updateRow()
        {
            positionsTableAdapter.Update(positionNameTextBox.Text, salaryNumericUpDown.Value,
                PositionModel.id, PositionModel.positionName, PositionModel.salary);
        }

        public void updateInputs()
        {
            positionNameTextBox.Text = PositionModel.positionName;
            salaryNumericUpDown.Value = PositionModel.salary;
        }

        public void clearInputs()
        {
            positionNameTextBox.Text = "";
            salaryNumericUpDown.Value = 0;
        }

        public bool isIncorrectModel()
        {
            return PositionModel.id < 0 || PositionModel.salary < 0 || PositionModel.positionName == "";
        }

        public bool isIncorrectInputs()
        {
            return positionNameTextBox.Text == "" || salaryNumericUpDown.Value == 0;
        }

        private void positionsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PositionModel.id = Convert.ToInt32(positionsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            PositionModel.positionName = positionsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            PositionModel.salary = Convert.ToInt32(positionsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            updateInputs();
        }

        private void PositionsForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            PositionModel.reset();
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
                PositionModel.reset();
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
                PositionModel.reset();
                clearInputs();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
