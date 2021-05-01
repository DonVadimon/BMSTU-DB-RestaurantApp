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
    public partial class OrdersToDishesForm : Form, ICRUDForm
    {
        private static class OrderToDishesModel
        {
            public static int orderId { get; set; }
            public static int dishId { get; set; }
            public static void reset()
            {
                dishId = -1;
            }
        }
        public OrdersToDishesForm(int orderId)
        {
            InitializeComponent();
            OrderToDishesModel.orderId = orderId;
            formLabel.Text += " " + orderId;
        }

        private void updateDGVDataSource()
        {
            string query = "SELECT Dishes.DishId, Dishes.Title " +
                "FROM(OrdersToDishes INNER JOIN Dishes ON OrdersToDishes.DishId = Dishes.DishId) " +
                "WHERE(OrdersToDishes.OrderId = " + OrderToDishesModel.orderId.ToString() + ")";
            dishesDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            dishesDataGridView.Update();
        }

        private void OrdersToDishesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.OrdersToDishes". При необходимости она может быть перемещена или удалена.
            this.ordersToDishesTableAdapter.Fill(this.suetaDataSet.OrdersToDishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.DishesToProducts". При необходимости она может быть перемещена или удалена.
            this.dishesToProductsTableAdapter.Fill(this.suetaDataSet.DishesToProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.suetaDataSet.Dishes);
            updateDGVDataSource();
        }

        public void updateView()
        {
            ordersToDishesTableAdapter.Fill(suetaDataSet.OrdersToDishes);
            ordersToDishesBindingSource.ResetBindings(false);
            updateDGVDataSource();
        }

        public void insertRow()
        {
            ordersToDishesTableAdapter.Insert(dishesTableAdapter.GetData()
                .FirstOrDefault(d => d.Title == dishesComboBox.Text).DishId, OrderToDishesModel.orderId);
        }

        public void deleteRow()
        {
            ordersToDishesTableAdapter.Delete(OrderToDishesModel.dishId, OrderToDishesModel.orderId);
        }

        public void updateRow()
        {
            throw new NotImplementedException();
            /*ordersToDishesTableAdapter.Update(dishesTableAdapter.GetData()
                .FirstOrDefault(d => d.Title == dishesComboBox.Text).DishId, OrderToDishesModel.orderId,
                OrderToDishesModel.dishId, OrderToDishesModel.orderId);*/
        }

        public void updateInputs()
        {
            dishesComboBox.SelectedIndex = dishesComboBox
                .FindStringExact(dishesTableAdapter.GetData()
                .FirstOrDefault(d => d.DishId == OrderToDishesModel.dishId).Title);
        }

        public void clearInputs()
        {
            dishesComboBox.SelectedIndex = -1;
        }

        public bool isIncorrectModel()
        {
            return OrderToDishesModel.dishId < 0 || OrderToDishesModel.orderId < 0;
        }

        public bool isIncorrectInputs()
        {
            return dishesComboBox.SelectedIndex < 0;
        }

        private void dishesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderToDishesModel.dishId = Convert.ToInt32(dishesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateInputs();
        }

        private void OrdersToDishesForm_Click(object sender, EventArgs e)
        {
            OrderToDishesModel.reset();
            clearInputs();
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
                OrderToDishesModel.reset();
                clearInputs();
            }
        }
    }
}
