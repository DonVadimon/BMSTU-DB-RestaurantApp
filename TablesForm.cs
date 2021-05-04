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
    public partial class TablesForm : Form, ICRUDForm
    {
        private static class TableModel
        {
            public static int id { get; set; }
            public static int maxPeopleCount { get; set; }

            public static void reset()
            {
                id = -1;
                maxPeopleCount = -1;
            }
        }
        public TablesForm()
        {
            InitializeComponent();
            clearInputs();
            TableModel.reset();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet._Tables". При необходимости она может быть перемещена или удалена.
            this.tablesTableAdapter.Fill(this.suetaDataSet._Tables);
        }

        public void updateView()
        {
            tablesTableAdapter.Fill(suetaDataSet._Tables);
            tablesBindingSource.ResetBindings(false);
            tablesDataGridView.Update();
        }

        public void insertRow()
        {
            tablesTableAdapter.Insert(Convert.ToInt32(maxPeopleCountNumericUpDown.Value));
        }

        public void deleteRow()
        {
            tablesTableAdapter.Delete(TableModel.id, TableModel.maxPeopleCount);
        }

        public void updateRow()
        {
            tablesTableAdapter.Update(Convert.ToInt32(maxPeopleCountNumericUpDown.Value), TableModel.id, TableModel.maxPeopleCount);
        }

        public void updateInputs()
        {
            tableIdTextBox.Text = TableModel.id.ToString();
            maxPeopleCountNumericUpDown.Value = TableModel.maxPeopleCount;
        }

        public void clearInputs()
        {
            maxPeopleCountNumericUpDown.Value = 0;
        }

        public bool isIncorrectModel()
        {
            return TableModel.id < 0 || TableModel.maxPeopleCount < 0;
        }

        public bool isIncorrectInputs()
        {
            return maxPeopleCountNumericUpDown.Value == 0;
        }

        private void tablesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TableModel.id = Convert.ToInt32(tablesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            TableModel.maxPeopleCount = Convert.ToInt32(tablesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            updateInputs();
        }

        private void TablesForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            TableModel.reset();
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
                TableModel.reset();
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
                TableModel.reset();
                clearInputs();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportTablesForm f = new ReportTablesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
