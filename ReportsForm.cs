﻿using System;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeesListBtn_Click(object sender, EventArgs e)
        {
            ReportEmployeesForm f = new ReportEmployeesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void positionsListBtn_Click(object sender, EventArgs e)
        {
            ReportPositionsForm f = new ReportPositionsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void dishesListBtn_Click(object sender, EventArgs e)
        {
            ReportDishesForm f = new ReportDishesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void providersListBtn_Click(object sender, EventArgs e)
        {
            ReportProvidersForm f = new ReportProvidersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void NDSForeachDishBtn_Click(object sender, EventArgs e)
        {
            ReportNDSForm f = new ReportNDSForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void tablesListBtn_Click(object sender, EventArgs e)
        {
            ReportTablesForm f = new ReportTablesForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void productsListBtn_Click(object sender, EventArgs e)
        {
            ReportProductsForm f = new ReportProductsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
