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
    public partial class ReportOrderItemsForm : Form
    {
        private int orderId { get; set; }
        public ReportOrderItemsForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void ReportOrderItemsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ReportOrderItemsDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.DataTableTableAdapter.Fill(this.ReportOrderItemsDataSet.DataTable, orderId);

            this.reportViewer1.RefreshReport();
        }
    }
}
