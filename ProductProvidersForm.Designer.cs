
namespace kursologV2
{
    partial class ProductProvidersForm
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
            this.providersReportBtn = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.providerNameTextBox = new System.Windows.Forms.TextBox();
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
            this.productsProvidersDataGridView = new System.Windows.Forms.DataGridView();
            this.providerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProvidersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.productProvidersTableAdapter = new kursologV2.suetaDataSetTableAdapters.ProductProvidersTableAdapter();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsProvidersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProvidersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // providersReportBtn
            // 
            this.providersReportBtn.Location = new System.Drawing.Point(75, 672);
            this.providersReportBtn.Name = "providersReportBtn";
            this.providersReportBtn.Size = new System.Drawing.Size(75, 23);
            this.providersReportBtn.TabIndex = 61;
            this.providersReportBtn.Text = "ОТЧЕТ";
            this.providersReportBtn.UseVisualStyleBackColor = true;
            this.providersReportBtn.Click += new System.EventHandler(this.providersReportBtn_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(287, 196);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(404, 20);
            this.locationTextBox.TabIndex = 59;
            // 
            // providerNameTextBox
            // 
            this.providerNameTextBox.Location = new System.Drawing.Point(287, 97);
            this.providerNameTextBox.Name = "providerNameTextBox";
            this.providerNameTextBox.Size = new System.Drawing.Size(404, 20);
            this.providerNameTextBox.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Время доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Местоположение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Поставщик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 52;
            this.label1.Text = "Поставщики";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(260, 575);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 120);
            this.controlsPanel.TabIndex = 97;
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
            // productsProvidersDataGridView
            // 
            this.productsProvidersDataGridView.AllowUserToAddRows = false;
            this.productsProvidersDataGridView.AllowUserToDeleteRows = false;
            this.productsProvidersDataGridView.AutoGenerateColumns = false;
            this.productsProvidersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsProvidersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerIdDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.deliveryTimeDataGridViewTextBoxColumn});
            this.productsProvidersDataGridView.DataSource = this.productProvidersBindingSource;
            this.productsProvidersDataGridView.Location = new System.Drawing.Point(106, 298);
            this.productsProvidersDataGridView.Name = "productsProvidersDataGridView";
            this.productsProvidersDataGridView.ReadOnly = true;
            this.productsProvidersDataGridView.Size = new System.Drawing.Size(552, 250);
            this.productsProvidersDataGridView.TabIndex = 98;
            this.productsProvidersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsProvidersDataGridView_RowHeaderMouseClick);
            // 
            // providerIdDataGridViewTextBoxColumn
            // 
            this.providerIdDataGridViewTextBoxColumn.DataPropertyName = "ProviderId";
            this.providerIdDataGridViewTextBoxColumn.HeaderText = "ProviderId";
            this.providerIdDataGridViewTextBoxColumn.Name = "providerIdDataGridViewTextBoxColumn";
            this.providerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            this.providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.HeaderText = "ProviderName";
            this.providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            this.providerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryTimeDataGridViewTextBoxColumn
            // 
            this.deliveryTimeDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTime";
            this.deliveryTimeDataGridViewTextBoxColumn.HeaderText = "DeliveryTime";
            this.deliveryTimeDataGridViewTextBoxColumn.Name = "deliveryTimeDataGridViewTextBoxColumn";
            this.deliveryTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productProvidersBindingSource
            // 
            this.productProvidersBindingSource.DataMember = "ProductProviders";
            this.productProvidersBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productProvidersTableAdapter
            // 
            this.productProvidersTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(287, 254);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(404, 20);
            this.deliveryDateTimePicker.TabIndex = 99;
            this.deliveryDateTimePicker.Value = new System.DateTime(2021, 5, 1, 18, 43, 31, 0);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(287, 147);
            this.phoneTextBox.Mask = "(999) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(404, 20);
            this.phoneTextBox.TabIndex = 100;
            // 
            // ProductProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.productsProvidersDataGridView);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.providersReportBtn);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.providerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductProvidersForm";
            this.Text = "ProductProvidersForm";
            this.Load += new System.EventHandler(this.ProductProvidersForm_Load);
            this.Click += new System.EventHandler(this.ProductProvidersForm_Click);
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsProvidersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productProvidersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button providersReportBtn;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox providerNameTextBox;
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
        private System.Windows.Forms.DataGridView productsProvidersDataGridView;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource productProvidersBindingSource;
        private suetaDataSetTableAdapters.ProductProvidersTableAdapter productProvidersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
    }
}