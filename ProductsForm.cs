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
    public partial class ProductsForm : Form, ICRUDForm
    {
        private static class ProductModel
        {
            public static int id { get; set; }
            public static string productName { get; set; }
            public static int priceForUnit { get; set; }
            public static int providerId { get; set; }
            public static int unitId { get; set; }
            public static int weight { get; set; }

            public static void reset()
            {
                id = -1;
                productName = "";
                priceForUnit = -1;
                providerId = -1;
                unitId = -1;
                weight = -1;
            }
        }

        public ProductsForm()
        {
            InitializeComponent();
            clearInputs();
            ProductModel.reset();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.suetaDataSet.Units);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.ProductProviders". При необходимости она может быть перемещена или удалена.
            this.productProvidersTableAdapter.Fill(this.suetaDataSet.ProductProviders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.suetaDataSet.Products);
        }

        public void insertRow()
        {
            productsTableAdapter.Insert(productNameTextBox.Text, priceNumericUpDown.Value, productProvidersTableAdapter.GetData()
                .FirstOrDefault(pr => pr.ProviderName == providerComboBox.Text).ProviderId, unitsTableAdapter.GetData()
                .FirstOrDefault(u => u.Unit == unitComboBox.Text).UnitId, Convert.ToInt32(weightNumericUpDown.Value));
        }

        public void deleteRow()
        {
            productsTableAdapter.Delete(ProductModel.id, ProductModel.productName, ProductModel.priceForUnit,
                ProductModel.providerId, ProductModel.unitId, ProductModel.weight);
        }

        public void updateRow()
        {
            productsTableAdapter.Update(productNameTextBox.Text, priceNumericUpDown.Value, productProvidersTableAdapter.GetData()
                .FirstOrDefault(pr => pr.ProviderName == providerComboBox.Text).ProviderId, unitsTableAdapter.GetData()
                .FirstOrDefault(u => u.Unit == unitComboBox.Text).UnitId, Convert.ToInt32(weightNumericUpDown.Value),
                ProductModel.id, ProductModel.productName, ProductModel.priceForUnit,
                ProductModel.providerId, ProductModel.unitId, ProductModel.weight);
        }

        public void updateView()
        {
            productsTableAdapter.Fill(suetaDataSet.Products);
            productsBindingSource.ResetBindings(false);
            productsDataGridView.Update();
        }

        public void updateInputs()
        {
            productNameTextBox.Text = ProductModel.productName;
            priceNumericUpDown.Value = ProductModel.priceForUnit;
            providerComboBox.SelectedIndex = providerComboBox.FindStringExact(productProvidersTableAdapter.GetData()
                .FirstOrDefault(pr => pr.ProviderId == ProductModel.providerId).ProviderName);
            unitComboBox.SelectedIndex = unitComboBox.FindStringExact(unitsTableAdapter.GetData()
                .FirstOrDefault(u => u.UnitId == ProductModel.unitId).Unit);
            weightNumericUpDown.Value = ProductModel.weight;
        }

        public void clearInputs()
        {
            productNameTextBox.Text = "";
            priceNumericUpDown.Value = 0;
            providerComboBox.SelectedIndex = -1;
            unitComboBox.SelectedIndex = -1;
            weightNumericUpDown.Value = 0;
        }

        public bool isIncorrectModel()
        {
            return ProductModel.id < 0 || ProductModel.priceForUnit < 0 || ProductModel.productName == "" || ProductModel.providerId < 0 || ProductModel.unitId < 0 || ProductModel.weight < 0;
        }

        public bool isIncorrectInputs()
        {
            return productNameTextBox.Text == "" || priceNumericUpDown.Value == 0 || providerComboBox.SelectedIndex < 0 || unitComboBox.SelectedIndex < 0 || weightNumericUpDown.Value == 0;
        }

        private void productsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductModel.id = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ProductModel.productName = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProductModel.priceForUnit = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            ProductModel.providerId = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            ProductModel.unitId = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            ProductModel.weight = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            updateInputs();
        }

        private void ProductsForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            ProductModel.reset();
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
                ProductModel.reset();
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
                ProductModel.reset();
                clearInputs();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
