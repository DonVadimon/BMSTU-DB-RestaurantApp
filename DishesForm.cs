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
    public partial class DishesForm : Form, ICRUDForm
    {
        private static class DishModel
        {
            public static int id { get; set; }
            public static int price { get; set; }
            public static string title { get; set; }
            public static int unitId { get; set; }
            public static int weight { get; set; }
            public static string description { get; set; }
            public static int typeId { get; set; }
            public static void reset()
            {
                id = -1;
                price = -1;
                title = "";
                unitId = -1;
                weight = -1;
                description = "";
                typeId = -1;
            }
        }
        public DishesForm()
        {
            InitializeComponent();
            clearInputs();
            DishModel.reset();
        }

        private void DishesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.DisheTypes". При необходимости она может быть перемещена или удалена.
            this.disheTypesTableAdapter.Fill(this.suetaDataSet.DisheTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.suetaDataSet.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.suetaDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.DishesToProducts". При необходимости она может быть перемещена или удалена.
            this.dishesToProductsTableAdapter.Fill(this.suetaDataSet.DishesToProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.suetaDataSet.Dishes);
            for (int i = 0; i < disheTypesTableAdapter.GetData().Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Checked = false;
                rb.Enabled = true;
                rb.Text = disheTypesTableAdapter.GetData()[i].Type;
                RBtableLayoutPanel.Controls.Add(rb);
                RBtableLayoutPanel.Update();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void updateView()
        {
            dishesTableAdapter.Fill(suetaDataSet.Dishes);
            dishesBindingSource.ResetBindings(false);
            dishesDataGridView.Update();
        }

        public void insertRow()
        {
            dishesTableAdapter.Insert(priceNumericUpDown.Value, titleTextBox.Text, unitsTableAdapter.GetData().First(u => u.Unit == unitsComboBox.Text).UnitId, Convert.ToInt32(weigthNumericUpDown.Value), descriptionRichTextBox.Text,
                disheTypesTableAdapter.GetData().First(t => t.Type == RBtableLayoutPanel.Controls.OfType<RadioButton>().First(r => r.Checked == true).Text).DishTypeId);
            updateView();
        }

        public void deleteRow()
        {
            dishesTableAdapter.Delete(DishModel.id, DishModel.price, DishModel.title, DishModel.unitId, DishModel.weight, DishModel.description, DishModel.typeId);
            updateView();
        }

        public void updateRow()
        {
            dishesTableAdapter.Update(priceNumericUpDown.Value, titleTextBox.Text, unitsTableAdapter.GetData().First(u => u.Unit == unitsComboBox.Text).UnitId, Convert.ToInt32(weigthNumericUpDown.Value), descriptionRichTextBox.Text,
                disheTypesTableAdapter.GetData().First(t => t.Type == RBtableLayoutPanel.Controls.OfType<RadioButton>().First(r => r.Checked == true).Text).DishTypeId,
                DishModel.id, DishModel.price, DishModel.title, DishModel.unitId, DishModel.weight, DishModel.description, DishModel.typeId);
            updateView();
        }

        public void updateInputs()
        {
            priceNumericUpDown.Value = DishModel.price;
            titleTextBox.Text = DishModel.title;
            unitsComboBox.SelectedIndex = unitsComboBox.FindString(unitsTableAdapter.GetData().FirstOrDefault(u => u.UnitId == DishModel.unitId).Unit);
            weigthNumericUpDown.Value = DishModel.weight;
            descriptionRichTextBox.Text = DishModel.description;
            RBtableLayoutPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Text == disheTypesTableAdapter.GetData().FirstOrDefault(t => t.DishTypeId == DishModel.typeId).Type).Checked = true;
            string query = "SELECT DishesToProducts.ProductId, Products.Product " +
                "FROM((Dishes INNER JOIN DishesToProducts ON Dishes.DishId = DishesToProducts.DishId) " +
                "INNER JOIN Products ON DishesToProducts.ProductId = Products.ProductId) " +
                "WHERE(Dishes.DishId = " + DishModel.id.ToString() + ")";
            changeDishToProductsButton.Enabled = true;
            productsDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
        }

        public void clearInputs()
        {
            priceNumericUpDown.Value = 0;
            titleTextBox.Text = "";
            unitsComboBox.SelectedIndex = -1;
            weigthNumericUpDown.Value = 0;
            descriptionRichTextBox.Text = "";
            RBtableLayoutPanel.Controls.OfType<RadioButton>().Select(rb => rb.Checked = false);
            productsDataGridView.DataSource = null;
            changeDishToProductsButton.Enabled = false;
            for (int i = 0; i < dishesDataGridView.Rows.Count; i++)
            {
                dishesDataGridView.Rows[i].Selected = false;
            }
            productsDataGridView.Update();
        }

        public bool isIncorrectModel()
        {
            return DishModel.id < 0 || DishModel.price < 0 || DishModel.weight < 0 ||
                DishModel.typeId < 0 || DishModel.unitId < 0 || DishModel.description.Length == 0 || DishModel.title.Length == 0;
        }

        public bool isIncorrectInputs()
        {
            return priceNumericUpDown.Value == 0 || titleTextBox.Text.Trim().Length == 0 || unitsComboBox.SelectedIndex < 0 || weigthNumericUpDown.Value == 0 ||
                descriptionRichTextBox.Text.Trim().Length == 0 || RBtableLayoutPanel.Controls.OfType<RadioButton>().Any(r => r.Checked == true) == false;
        }

        private void dishesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DishModel.id = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            DishModel.price = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            DishModel.title = dishesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            DishModel.unitId = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            DishModel.weight = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            DishModel.description = dishesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            DishModel.typeId = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            updateInputs();
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
                DishModel.reset();
                clearInputs();
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
                DishModel.reset();
                clearInputs();
            }
        }

        private void DishesForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            DishModel.reset();
        }

        private void changeDishToProductsButton_Click(object sender, EventArgs e)
        {
            DishesToProductsForm f = new DishesToProductsForm(DishModel.id, DishModel.title);
            Hide();
            f.ShowDialog(this);
            Show();
            updateInputs();
        }

        private void NDSReportBtn_Click(object sender, EventArgs e)
        {
            ReportNDSForm f = new ReportNDSForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
