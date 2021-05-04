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
    public partial class ProductProvidersForm : Form, ICRUDForm
    {
        private static class ProductProviderModel
        {
            public static int id { get; set; }
            public static string Name { get; set; }
            public static string Phone { get; set; }
            public static string Location { get; set; }
            public static DateTime DeliveryTime { get; set; }
            public static void reset()
            {
                id = -1;
                Name = "";
                Phone = "";
                Location = "";
                DeliveryTime = DateTime.Now;
            }
        }
        public ProductProvidersForm()
        {
            InitializeComponent();
            clearInputs();
            ProductProviderModel.reset();
        }

        private void ProductProvidersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.ProductProviders". При необходимости она может быть перемещена или удалена.
            this.productProvidersTableAdapter.Fill(this.suetaDataSet.ProductProviders);
            productsProvidersDataGridView.Columns[productsProvidersDataGridView.Columns.Count - 1].DefaultCellStyle.Format = "hh:mm:ss";
        }

        public void clearInputs()
        {
            providerNameTextBox.Text = "";
            phoneTextBox.Text = "";
            locationTextBox.Text = "";
        }

        public void updateInputs()
        {
            providerNameTextBox.Text = ProductProviderModel.Name;
            phoneTextBox.Text = ProductProviderModel.Phone;
            MessageBox.Show(phoneTextBox.Text.Length.ToString());
            locationTextBox.Text = ProductProviderModel.Location;
            deliveryDateTimePicker.Value = ProductProviderModel.DeliveryTime;
        }

        public void updateView()
        {
            productProvidersTableAdapter.Fill(suetaDataSet.ProductProviders);
            productProvidersBindingSource.ResetBindings(false);
            productsProvidersDataGridView.Update();
        }

        public bool isIncorrectInputs()
        {
            return providerNameTextBox.Text == "" || phoneTextBox.Text == "" || locationTextBox.Text == "";
        }

        public bool isIncorrectModel()
        {
            return ProductProviderModel.id < 0 || ProductProviderModel.Name == "" || ProductProviderModel.Phone == "" ||
                ProductProviderModel.Location == "";
        }

        public void insertRow()
        {
            productProvidersTableAdapter.Insert(providerNameTextBox.Text, phoneTextBox.Text, locationTextBox.Text,
                deliveryDateTimePicker.Value);
        }

        public void deleteRow()
        {
            productProvidersTableAdapter.Delete(ProductProviderModel.id, ProductProviderModel.Name, ProductProviderModel.Phone,
                ProductProviderModel.Location, ProductProviderModel.DeliveryTime);
        }

        public void updateRow()
        {
            productProvidersTableAdapter.Update(providerNameTextBox.Text, phoneTextBox.Text, locationTextBox.Text,
                deliveryDateTimePicker.Value, ProductProviderModel.id, ProductProviderModel.Name, ProductProviderModel.Phone,
                ProductProviderModel.Location, ProductProviderModel.DeliveryTime);
        }

        private void productsProvidersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductProviderModel.id = Convert.ToInt32(productsProvidersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ProductProviderModel.Name = productsProvidersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProductProviderModel.Phone = productsProvidersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ProductProviderModel.Location = productsProvidersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            ProductProviderModel.DeliveryTime = Convert.ToDateTime(productsProvidersDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            updateInputs();
        }

        private void ProductProvidersForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            ProductProviderModel.reset();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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
                ProductProviderModel.reset();
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
                ProductProviderModel.reset();
                clearInputs();
            }
        }

        private void providersReportBtn_Click(object sender, EventArgs e)
        {
            ReportProvidersForm f = new ReportProvidersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
