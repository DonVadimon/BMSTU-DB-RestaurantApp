
namespace kursologV2
{
    partial class DishesToProductsForm
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
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dishesToProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.dishesToProductsTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesToProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new kursologV2.suetaDataSetTableAdapters.ProductsTableAdapter();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.AutoSize = true;
            this.dishNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishNameLabel.Location = new System.Drawing.Point(181, 21);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(104, 31);
            this.dishNameLabel.TabIndex = 0;
            this.dishNameLabel.Text = "Состав";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(121, 75);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.Size = new System.Drawing.Size(246, 277);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productsDataGridView_RowHeaderMouseClick);
            // 
            // dishesToProductsBindingSource
            // 
            this.dishesToProductsBindingSource.DataMember = "DishesToProducts";
            this.dishesToProductsBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // productsComboBox
            // 
            this.productsComboBox.DataSource = this.productsBindingSource;
            this.productsComboBox.DisplayMember = "Product";
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(423, 75);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(180, 21);
            this.productsComboBox.TabIndex = 2;
            this.productsComboBox.ValueMember = "ProductId";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Location = new System.Drawing.Point(423, 102);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(130, 219);
            this.controlsPanel.TabIndex = 97;
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
            // dishesToProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 444);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.productsComboBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.dishNameLabel);
            this.Name = "dishesToProductsForm";
            this.Text = "dishesToProductsForm";
            this.Load += new System.EventHandler(this.dishesToProductsForm_Load);
            this.Click += new System.EventHandler(this.dishesToProductsForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesToProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dishNameLabel;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource dishesToProductsBindingSource;
        private suetaDataSetTableAdapters.DishesToProductsTableAdapter dishesToProductsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private suetaDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
    }
}