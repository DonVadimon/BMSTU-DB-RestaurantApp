
namespace kursologV2
{
    partial class OrdersToDishesForm
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
            this.formLabel = new System.Windows.Forms.Label();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dishesComboBox = new System.Windows.Forms.ComboBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.dishesTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesTableAdapter();
            this.dishesToProductsTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesToProductsTableAdapter();
            this.dishesToProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersToDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersToDishesTableAdapter = new kursologV2.suetaDataSetTableAdapters.OrdersToDishesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersToDishesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLabel.Location = new System.Drawing.Point(254, 31);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(232, 31);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Состав заказа №";
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.AllowUserToAddRows = false;
            this.dishesDataGridView.AllowUserToDeleteRows = false;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Location = new System.Drawing.Point(66, 150);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.ReadOnly = true;
            this.dishesDataGridView.Size = new System.Drawing.Size(420, 172);
            this.dishesDataGridView.TabIndex = 1;
            this.dishesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dishesDataGridView_RowHeaderMouseClick);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Location = new System.Drawing.Point(542, 150);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(130, 219);
            this.controlsPanel.TabIndex = 98;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(18, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 41);
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
            this.closeButton.Location = new System.Drawing.Point(18, 152);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(98, 49);
            this.closeButton.TabIndex = 55;
            this.closeButton.Text = "Закрыть форму";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dishesComboBox
            // 
            this.dishesComboBox.DataSource = this.dishesBindingSource;
            this.dishesComboBox.DisplayMember = "Title";
            this.dishesComboBox.FormattingEnabled = true;
            this.dishesComboBox.Location = new System.Drawing.Point(542, 100);
            this.dishesComboBox.Name = "dishesComboBox";
            this.dishesComboBox.Size = new System.Drawing.Size(168, 21);
            this.dishesComboBox.TabIndex = 99;
            this.dishesComboBox.ValueMember = "DishId";
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesToProductsTableAdapter
            // 
            this.dishesToProductsTableAdapter.ClearBeforeFill = true;
            // 
            // dishesToProductsBindingSource
            // 
            this.dishesToProductsBindingSource.DataMember = "DishesToProducts";
            this.dishesToProductsBindingSource.DataSource = this.suetaDataSet;
            // 
            // ordersToDishesBindingSource
            // 
            this.ordersToDishesBindingSource.DataMember = "OrdersToDishes";
            this.ordersToDishesBindingSource.DataSource = this.suetaDataSet;
            // 
            // ordersToDishesTableAdapter
            // 
            this.ordersToDishesTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersToDishesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dishesComboBox);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.dishesDataGridView);
            this.Controls.Add(this.formLabel);
            this.Name = "OrdersToDishesForm";
            this.Text = "OrdersToDishesForm";
            this.Load += new System.EventHandler(this.OrdersToDishesForm_Load);
            this.Click += new System.EventHandler(this.OrdersToDishesForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersToDishesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox dishesComboBox;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private suetaDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private suetaDataSetTableAdapters.DishesToProductsTableAdapter dishesToProductsTableAdapter;
        private System.Windows.Forms.BindingSource dishesToProductsBindingSource;
        private System.Windows.Forms.BindingSource ordersToDishesBindingSource;
        private suetaDataSetTableAdapters.OrdersToDishesTableAdapter ordersToDishesTableAdapter;
    }
}