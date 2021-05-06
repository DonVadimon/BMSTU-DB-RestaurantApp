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
    public partial class DishesToProductsForm : Form, ICRUDForm
    {
        private static class DishToProductsModel
        {
            public static int dishId { get; set; } = -1;
            public static int productId { get; set; } = -1;

            public static void reset()
            {
                productId = -1;
            }
        }
        public DishesToProductsForm(int dishId, string dishTitle)
        {
            InitializeComponent();
            DishToProductsModel.dishId = dishId;
            dishNameLabel.Text += " " + dishTitle;
        }

        private void updateDGVDataSource()
        {
            string query = "SELECT Products.ProductId, Products.Product FROM" +
                "(DishesToProducts INNER JOIN Products ON DishesToProducts.ProductId = Products.ProductId) " +
                "WHERE(DishesToProducts.DishId = " + DishToProductsModel.dishId.ToString() + ")";
            productsDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            productsDataGridView.Update();
        }

        private void dishesToProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.suetaDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.DishesToProducts". При необходимости она может быть перемещена или удалена.
            this.dishesToProductsTableAdapter.Fill(this.suetaDataSet.DishesToProducts);
            updateDGVDataSource();
        }

        public void updateView()
        {
            dishesToProductsTableAdapter.Fill(suetaDataSet.DishesToProducts);
            dishesToProductsBindingSource.ResetBindings(false);
            updateDGVDataSource();
        }

        public void insertRow()
        {
            dishesToProductsTableAdapter.Insert(DishToProductsModel.dishId, productsTableAdapter.GetData()
                .FirstOrDefault(pr => pr.Product == productsComboBox.Text).ProductId);
        }

        public void deleteRow()
        {
            dishesToProductsTableAdapter.Delete(DishToProductsModel.dishId, DishToProductsModel.productId);
        }

        public void updateRow()
        {
            throw new NotImplementedException();
        }

        public void updateInputs()
        {
            productsComboBox.SelectedIndex = productsComboBox.FindString(productsTableAdapter.GetData().FirstOrDefault(pr => pr.ProductId == DishToProductsModel.productId).Product);
        }

        public void clearInputs()
        {
            productsComboBox.SelectedIndex = -1;
            for (int i = 0; i < productsDataGridView.Rows.Count; i++)
            {
                productsDataGridView.Rows[i].Selected = false;
            }
            productsDataGridView.Update();
        }

        public bool isIncorrectModel()
        {
            return DishToProductsModel.productId < 0 || DishToProductsModel.dishId < 0;
        }

        public bool isIncorrectInputs()
        {
            return productsComboBox.SelectedIndex < 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Выберите продукт");
            }
            else
            {
                try
                {
                    insertRow();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                updateView();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel())
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                deleteRow();
                updateView();
                DishToProductsModel.reset();
                clearInputs();
            }
        }

        private void dishesToProductsForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            DishToProductsModel.reset();
        }

        private void productsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DishToProductsModel.productId = Convert.ToInt32(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateInputs();
        }
    }
}
