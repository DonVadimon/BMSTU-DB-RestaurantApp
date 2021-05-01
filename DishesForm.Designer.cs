
namespace kursologV2
{
    partial class DishesForm
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
            this.weigthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dishesTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.RBtableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.dishIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesTableAdapter();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dishesToProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesToProductsTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesToProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new kursologV2.suetaDataSetTableAdapters.ProductsTableAdapter();
            this.unitsTableAdapter = new kursologV2.suetaDataSetTableAdapters.UnitsTableAdapter();
            this.disheTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disheTypesTableAdapter = new kursologV2.suetaDataSetTableAdapters.DisheTypesTableAdapter();
            this.changeDishToProductsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weigthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.dishesTypesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disheTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // weigthNumericUpDown
            // 
            this.weigthNumericUpDown.Location = new System.Drawing.Point(222, 247);
            this.weigthNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.weigthNumericUpDown.Name = "weigthNumericUpDown";
            this.weigthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.weigthNumericUpDown.TabIndex = 95;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(225, 105);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceNumericUpDown.TabIndex = 94;
            // 
            // dishesTypesGroupBox
            // 
            this.dishesTypesGroupBox.Controls.Add(this.RBtableLayoutPanel);
            this.dishesTypesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishesTypesGroupBox.Location = new System.Drawing.Point(604, 90);
            this.dishesTypesGroupBox.Name = "dishesTypesGroupBox";
            this.dishesTypesGroupBox.Size = new System.Drawing.Size(213, 235);
            this.dishesTypesGroupBox.TabIndex = 90;
            this.dishesTypesGroupBox.TabStop = false;
            this.dishesTypesGroupBox.Text = "Типы Блюда";
            // 
            // RBtableLayoutPanel
            // 
            this.RBtableLayoutPanel.ColumnCount = 1;
            this.RBtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RBtableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBtableLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.RBtableLayoutPanel.Name = "RBtableLayoutPanel";
            this.RBtableLayoutPanel.RowCount = 5;
            this.RBtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RBtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RBtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RBtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RBtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.RBtableLayoutPanel.Size = new System.Drawing.Size(207, 207);
            this.RBtableLayoutPanel.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(185, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 42);
            this.label10.TabIndex = 89;
            this.label10.Text = "Блюда";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 800);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "ОТЧЕТ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 760);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "ОТЧЕТ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.DataSource = this.unitsBindingSource;
            this.unitsComboBox.DisplayMember = "Unit";
            this.unitsComboBox.FormattingEnabled = true;
            this.unitsComboBox.Location = new System.Drawing.Point(224, 199);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitsComboBox.TabIndex = 81;
            this.unitsComboBox.ValueMember = "UnitId";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(590, 48);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(125, 20);
            this.searchTextBox.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Поиск";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(224, 298);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(330, 64);
            this.descriptionRichTextBox.TabIndex = 78;
            this.descriptionRichTextBox.Text = "";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(224, 154);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(216, 20);
            this.titleTextBox.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Состав блюда";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 765);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "НДС для каждого блюда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Единица измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Цена";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(520, 703);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 120);
            this.controlsPanel.TabIndex = 96;
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
            // dishesDataGridView
            // 
            this.dishesDataGridView.AllowUserToAddRows = false;
            this.dishesDataGridView.AllowUserToDeleteRows = false;
            this.dishesDataGridView.AutoGenerateColumns = false;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.unitIdDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn});
            this.dishesDataGridView.DataSource = this.dishesBindingSource;
            this.dishesDataGridView.Location = new System.Drawing.Point(14, 379);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.ReadOnly = true;
            this.dishesDataGridView.Size = new System.Drawing.Size(758, 303);
            this.dishesDataGridView.TabIndex = 97;
            this.dishesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dishesDataGridView_RowHeaderMouseClick);
            // 
            // dishIdDataGridViewTextBoxColumn
            // 
            this.dishIdDataGridViewTextBoxColumn.DataPropertyName = "DishId";
            this.dishIdDataGridViewTextBoxColumn.HeaderText = "DishId";
            this.dishIdDataGridViewTextBoxColumn.Name = "dishIdDataGridViewTextBoxColumn";
            this.dishIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            this.unitIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.suetaDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(793, 379);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(250, 302);
            this.productsDataGridView.TabIndex = 98;
            // 
            // dishesToProductsBindingSource
            // 
            this.dishesToProductsBindingSource.DataMember = "DishesToProducts";
            this.dishesToProductsBindingSource.DataSource = this.suetaDataSet;
            // 
            // dishesToProductsTableAdapter
            // 
            this.dishesToProductsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.suetaDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // disheTypesBindingSource
            // 
            this.disheTypesBindingSource.DataMember = "DisheTypes";
            this.disheTypesBindingSource.DataSource = this.suetaDataSet;
            // 
            // disheTypesTableAdapter
            // 
            this.disheTypesTableAdapter.ClearBeforeFill = true;
            // 
            // changeDishToProductsButton
            // 
            this.changeDishToProductsButton.Location = new System.Drawing.Point(839, 333);
            this.changeDishToProductsButton.Name = "changeDishToProductsButton";
            this.changeDishToProductsButton.Size = new System.Drawing.Size(109, 29);
            this.changeDishToProductsButton.TabIndex = 99;
            this.changeDishToProductsButton.Text = "Состав блюда";
            this.changeDishToProductsButton.UseVisualStyleBackColor = true;
            this.changeDishToProductsButton.Click += new System.EventHandler(this.changeDishToProductsButton_Click);
            // 
            // DishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 843);
            this.Controls.Add(this.changeDishToProductsButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.dishesDataGridView);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.weigthNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.dishesTypesGroupBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unitsComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DishesForm";
            this.Text = "DishesForm";
            this.Load += new System.EventHandler(this.DishesForm_Load);
            this.Click += new System.EventHandler(this.DishesForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.weigthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.dishesTypesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disheTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown weigthNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.GroupBox dishesTypesGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox unitsComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private suetaDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.BindingSource dishesToProductsBindingSource;
        private suetaDataSetTableAdapters.DishesToProductsTableAdapter dishesToProductsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private suetaDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private suetaDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private System.Windows.Forms.BindingSource disheTypesBindingSource;
        private suetaDataSetTableAdapters.DisheTypesTableAdapter disheTypesTableAdapter;
        private System.Windows.Forms.Button changeDishToProductsButton;
        private System.Windows.Forms.TableLayoutPanel RBtableLayoutPanel;
    }
}