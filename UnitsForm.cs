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
    public partial class UnitsForm : Form, ICRUDForm
    {
        private static class UnitModel
        {
            public static int id { get; set; } = -1;
            public static string unit { get; set; } = "";
            public static void reset()
            {
                id = -1;
                unit = "";
            }
        }
        public UnitsForm()
        {
            InitializeComponent();
        }

        private void UnitsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.suetaDataSet.Units);
        }
        public bool isIncorrectModel()
        {
            return UnitModel.id < 0 || UnitModel.unit.Trim().Length == 0;
        }
        public bool isIncorrectInputs()
        {
            return unitTextBox.Text.Trim().Length == 0;
        }
        public void updateView()
        {
            unitsTableAdapter.Fill(suetaDataSet.Units);
            unitsBindingSource.ResetBindings(false);
            unitsDataGridView.Update();
        }
         public void insertRow()
        {
            unitsTableAdapter.Insert(unitTextBox.Text);
            updateView();
        }
         public void deleteRow()
        {
            unitsTableAdapter.Delete(UnitModel.id, UnitModel.unit);
            updateView();
        }

         public void updateRow()
        {
            unitsTableAdapter.Update(unitTextBox.Text, UnitModel.id, UnitModel.unit);
            updateView();
        }
         public void updateInputs()
        {
            unitTextBox.Text = UnitModel.unit;
        }
         public void clearInputs()
        {
            unitTextBox.Text = "";
            for (int i = 0; i < unitsDataGridView.Rows.Count; i++)
            {
                unitsDataGridView.Rows[i].Selected = false;
            }
            unitsDataGridView.Update();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void unitsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UnitModel.id = Convert.ToInt32(unitsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            UnitModel.unit = unitsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateInputs();
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
                UnitModel.reset();
                clearInputs();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Введите единицу измерения");
            }
            else
            {
                insertRow();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel() || isIncorrectInputs())
            {
                MessageBox.Show("Выберите строку и введите новое значение");
            }
            else
            {
                updateRow();
                UnitModel.reset();
                clearInputs();
            }
        }

        private void UnitsForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            UnitModel.reset();
        }
    }
}
