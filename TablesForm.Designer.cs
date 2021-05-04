
namespace kursologV2
{
    partial class TablesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.maxPeopleCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tablesDataGridView = new System.Windows.Forms.DataGridView();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPeopleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.tablesTableAdapter = new kursologV2.suetaDataSetTableAdapters.TablesTableAdapter();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxPeopleCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "ОТЧЕТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableIdTextBox
            // 
            this.tableIdTextBox.Enabled = false;
            this.tableIdTextBox.Location = new System.Drawing.Point(276, 108);
            this.tableIdTextBox.Name = "tableIdTextBox";
            this.tableIdTextBox.Size = new System.Drawing.Size(221, 20);
            this.tableIdTextBox.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Максимальное количество людей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Номер столика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 71;
            this.label1.Text = "Столик";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(26, 237);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 120);
            this.controlsPanel.TabIndex = 77;
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
            this.closeButton.Size = new System.Drawing.Size(81, 49);
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
            // maxPeopleCountNumericUpDown
            // 
            this.maxPeopleCountNumericUpDown.Location = new System.Drawing.Point(276, 164);
            this.maxPeopleCountNumericUpDown.Name = "maxPeopleCountNumericUpDown";
            this.maxPeopleCountNumericUpDown.Size = new System.Drawing.Size(221, 20);
            this.maxPeopleCountNumericUpDown.TabIndex = 78;
            // 
            // tablesDataGridView
            // 
            this.tablesDataGridView.AllowUserToAddRows = false;
            this.tablesDataGridView.AllowUserToDeleteRows = false;
            this.tablesDataGridView.AutoGenerateColumns = false;
            this.tablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableIdDataGridViewTextBoxColumn,
            this.maxPeopleCountDataGridViewTextBoxColumn});
            this.tablesDataGridView.DataSource = this.tablesBindingSource;
            this.tablesDataGridView.Location = new System.Drawing.Point(527, 30);
            this.tablesDataGridView.Name = "tablesDataGridView";
            this.tablesDataGridView.ReadOnly = true;
            this.tablesDataGridView.Size = new System.Drawing.Size(251, 373);
            this.tablesDataGridView.TabIndex = 79;
            this.tablesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablesDataGridView_RowHeaderMouseClick);
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "TableId";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            this.tableIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxPeopleCountDataGridViewTextBoxColumn
            // 
            this.maxPeopleCountDataGridViewTextBoxColumn.DataPropertyName = "MaxPeopleCount";
            this.maxPeopleCountDataGridViewTextBoxColumn.HeaderText = "MaxPeopleCount";
            this.maxPeopleCountDataGridViewTextBoxColumn.Name = "maxPeopleCountDataGridViewTextBoxColumn";
            this.maxPeopleCountDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.tablesDataGridView);
            this.Controls.Add(this.maxPeopleCountNumericUpDown);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.Click += new System.EventHandler(this.TablesForm_Click);
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxPeopleCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tableIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown maxPeopleCountNumericUpDown;
        private System.Windows.Forms.DataGridView tablesDataGridView;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private suetaDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPeopleCountDataGridViewTextBoxColumn;
    }
}