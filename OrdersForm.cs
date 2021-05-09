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
    public partial class OrdersForm : Form, ICRUDForm
    {
        private static class OrderModel
        {
            public static int id { get; set; }
            public static int waiterId { get; set; }
            public static int tableId { get; set; }
            public static void reset()
            {
                id = -1;
                waiterId = -1;
                tableId = -1;
            }
        }

        public OrdersForm()
        {
            InitializeComponent();
            List<string> waiters = employeesTableAdapter.GetData().Where(emp => emp.PositionId == 1).Select(w => w.FullName).ToList<string>();
            foreach (string waiter in waiters)
            {
                waitersComboBox.Items.Add(waiter);
            }
            waitersComboBox.Update();
            OrderModel.reset();
            clearInputs();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.suetaDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet._Tables". При необходимости она может быть перемещена или удалена.
            this.tablesTableAdapter.Fill(this.suetaDataSet._Tables);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.suetaDataSet.Orders);

        }

        public void updateView()
        {
            ordersTableAdapter.Fill(suetaDataSet.Orders);
            ordersBindingSource.ResetBindings(false);
            ordersDataGridView.Update();
        }

        public void insertRow()
        {
            ordersTableAdapter.Insert(employeesTableAdapter.GetData()
                .FirstOrDefault(emp => emp.FullName == waitersComboBox.Text).EmployeeId, Convert.ToInt32(tableComboBox.Text));
        }

        public void deleteRow()
        {
            ordersTableAdapter.Delete(OrderModel.id, OrderModel.waiterId, OrderModel.tableId);
        }

        public void updateRow()
        {
            ordersTableAdapter.Update(employeesTableAdapter.GetData()
                .FirstOrDefault(emp => emp.FullName == waitersComboBox.Text).EmployeeId, Convert.ToInt32(tableComboBox.Text)
                , OrderModel.id, OrderModel.waiterId, OrderModel.tableId);
        }

        public void updateInputs()
        {
            waitersComboBox.SelectedIndex = waitersComboBox
                .FindStringExact(employeesTableAdapter.GetData()
                .FirstOrDefault(emp => emp.EmployeeId == OrderModel.waiterId).FullName);
            tableComboBox.SelectedIndex = tableComboBox.FindStringExact(OrderModel.tableId.ToString());
            string query = "SELECT Dishes.DishId, Dishes.Title " +
                "FROM((Orders INNER JOIN OrdersToDishes ON Orders.OrderId = OrdersToDishes.OrderId) " +
                "INNER JOIN Dishes ON OrdersToDishes.DishId = Dishes.DishId) " +
                "WHERE(Orders.OrderId = " + OrderModel.id.ToString() + ")";
            dishesDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            changeOrderDishesButton.Enabled = true;
            orderInfoBtn.Enabled = true;
        }

        public void clearInputs()
        {
            waitersComboBox.SelectedIndex = -1;
            tableComboBox.SelectedIndex = -1;
            changeOrderDishesButton.Enabled = false;
            orderInfoBtn.Enabled = false;
            for (int i = 0; i < ordersDataGridView.Rows.Count; i++)
            {
                ordersDataGridView.Rows[i].Selected = false;
            }
            ordersDataGridView.Update();
        }

        public bool isIncorrectModel()
        {
            return OrderModel.id < 0 || OrderModel.tableId < 0 || OrderModel.waiterId < 0;
        }

        public bool isIncorrectInputs()
        {
            return waitersComboBox.SelectedIndex < 0 || tableComboBox.SelectedIndex < 0;
        }
        private void getWaitersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.GetWaiters(this.suetaDataSet.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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
                OrderModel.reset();
                clearInputs();
            }
        }

        private void ordersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderModel.id = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            OrderModel.waiterId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            OrderModel.tableId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
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
                updateView();
                OrderModel.reset();
                clearInputs();
            }
        }

        private void OrdersForm_Click(object sender, EventArgs e)
        {
            OrderModel.reset();
            clearInputs();
        }

        private void changeOrderDishesButton_Click(object sender, EventArgs e)
        {
            OrdersToDishesForm f = new OrdersToDishesForm(OrderModel.id);
            Hide();
            f.ShowDialog(this);
            Show();
            updateView();
            updateInputs();
        }

        private void ordersPriceReportBtn_Click(object sender, EventArgs e)
        {
            ReportOrdersForm f = new ReportOrdersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void orderInfoBtn_Click(object sender, EventArgs e)
        {
            ReportOrderItemsForm f = new ReportOrderItemsForm(OrderModel.id);
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
