
namespace kursologV2
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.waitersComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ordersPriceReportBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new kursologV2.suetaDataSetTableAdapters.OrdersTableAdapter();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.tablesTableAdapter = new kursologV2.suetaDataSetTableAdapters.TablesTableAdapter();
            this.employeesTableAdapter = new kursologV2.suetaDataSetTableAdapters.EmployeesTableAdapter();
            this.getWaitersToolStrip = new System.Windows.Forms.ToolStrip();
            this.getWaitersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.changeOrderDishesButton = new System.Windows.Forms.Button();
            this.orderInfoBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.getWaitersToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableComboBox
            // 
            this.tableComboBox.DataSource = this.tablesBindingSource;
            this.tableComboBox.DisplayMember = "TableId";
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(373, 174);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(269, 21);
            this.tableComboBox.TabIndex = 10;
            this.tableComboBox.ValueMember = "TableId";
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "Tables";
            this.tablesBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waitersComboBox
            // 
            this.waitersComboBox.FormattingEnabled = true;
            this.waitersComboBox.Location = new System.Drawing.Point(373, 107);
            this.waitersComboBox.Name = "waitersComboBox";
            this.waitersComboBox.Size = new System.Drawing.Size(269, 21);
            this.waitersComboBox.TabIndex = 9;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.suetaDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Столик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Официант";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(327, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заказ";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(173, 518);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 120);
            this.controlsPanel.TabIndex = 59;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(347, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 41);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 40);
            this.addButton.TabIndex = 54;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(347, 68);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 49);
            this.closeButton.TabIndex = 55;
            this.closeButton.Text = "Закрыть форму";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(186, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 40);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Сохранить Запись";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ordersPriceReportBtn
            // 
            this.ordersPriceReportBtn.Location = new System.Drawing.Point(194, 667);
            this.ordersPriceReportBtn.Name = "ordersPriceReportBtn";
            this.ordersPriceReportBtn.Size = new System.Drawing.Size(75, 23);
            this.ordersPriceReportBtn.TabIndex = 61;
            this.ordersPriceReportBtn.Text = "ОТЧЕТ";
            this.ordersPriceReportBtn.UseVisualStyleBackColor = true;
            this.ordersPriceReportBtn.Click += new System.EventHandler(this.ordersPriceReportBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Стоимость заказов";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.waiterIdDataGridViewTextBoxColumn,
            this.tableIdDataGridViewTextBoxColumn});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(81, 281);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(355, 191);
            this.ordersDataGridView.TabIndex = 62;
            this.ordersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ordersDataGridView_RowHeaderMouseClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waiterIdDataGridViewTextBoxColumn
            // 
            this.waiterIdDataGridViewTextBoxColumn.DataPropertyName = "WaiterId";
            this.waiterIdDataGridViewTextBoxColumn.HeaderText = "WaiterId";
            this.waiterIdDataGridViewTextBoxColumn.Name = "waiterIdDataGridViewTextBoxColumn";
            this.waiterIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "TableId";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            this.tableIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.suetaDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.AllowUserToAddRows = false;
            this.dishesDataGridView.AllowUserToDeleteRows = false;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Location = new System.Drawing.Point(504, 281);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.ReadOnly = true;
            this.dishesDataGridView.Size = new System.Drawing.Size(266, 190);
            this.dishesDataGridView.TabIndex = 63;
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // getWaitersToolStrip
            // 
            this.getWaitersToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.getWaitersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getWaitersToolStripButton});
            this.getWaitersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.getWaitersToolStrip.Name = "getWaitersToolStrip";
            this.getWaitersToolStrip.Size = new System.Drawing.Size(800, 25);
            this.getWaitersToolStrip.TabIndex = 64;
            this.getWaitersToolStrip.Text = "getWaitersToolStrip";
            // 
            // getWaitersToolStripButton
            // 
            this.getWaitersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getWaitersToolStripButton.Name = "getWaitersToolStripButton";
            this.getWaitersToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.getWaitersToolStripButton.Text = "GetWaiters";
            this.getWaitersToolStripButton.Click += new System.EventHandler(this.getWaitersToolStripButton_Click);
            // 
            // changeOrderDishesButton
            // 
            this.changeOrderDishesButton.Location = new System.Drawing.Point(580, 241);
            this.changeOrderDishesButton.Name = "changeOrderDishesButton";
            this.changeOrderDishesButton.Size = new System.Drawing.Size(122, 23);
            this.changeOrderDishesButton.TabIndex = 65;
            this.changeOrderDishesButton.Text = "Состав заказа";
            this.changeOrderDishesButton.UseVisualStyleBackColor = true;
            this.changeOrderDishesButton.Click += new System.EventHandler(this.changeOrderDishesButton_Click);
            // 
            // orderInfoBtn
            // 
            this.orderInfoBtn.Location = new System.Drawing.Point(475, 667);
            this.orderInfoBtn.Name = "orderInfoBtn";
            this.orderInfoBtn.Size = new System.Drawing.Size(77, 23);
            this.orderInfoBtn.TabIndex = 66;
            this.orderInfoBtn.Text = "ОТЧЕТ";
            this.orderInfoBtn.UseVisualStyleBackColor = true;
            this.orderInfoBtn.Click += new System.EventHandler(this.orderInfoBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Информация о заказе";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orderInfoBtn);
            this.Controls.Add(this.changeOrderDishesButton);
            this.Controls.Add(this.getWaitersToolStrip);
            this.Controls.Add(this.dishesDataGridView);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.ordersPriceReportBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.waitersComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.Click += new System.EventHandler(this.OrdersForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.getWaitersToolStrip.ResumeLayout(false);
            this.getWaitersToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.ComboBox waitersComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button ordersPriceReportBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private suetaDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private suetaDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private suetaDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ToolStrip getWaitersToolStrip;
        private System.Windows.Forms.ToolStripButton getWaitersToolStripButton;
        private System.Windows.Forms.Button changeOrderDishesButton;
        private System.Windows.Forms.Button orderInfoBtn;
        private System.Windows.Forms.Label label5;
    }
}