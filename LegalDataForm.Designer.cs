
namespace kursologV2
{
    partial class LegalDataForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.clientInfoBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.restaurantTitleTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.INNTextBox = new System.Windows.Forms.MaskedTextBox();
            this.foundationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.openingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeesTableAdapter = new kursologV2.suetaDataSetTableAdapters.EmployeesTableAdapter();
            this.legalDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.legalDataTableAdapter = new kursologV2.suetaDataSetTableAdapters.LegalDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Информация для клиентов";
            // 
            // clientInfoBtn
            // 
            this.clientInfoBtn.Location = new System.Drawing.Point(268, 563);
            this.clientInfoBtn.Name = "clientInfoBtn";
            this.clientInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.clientInfoBtn.TabIndex = 93;
            this.clientInfoBtn.Text = "ОТЧЕТ";
            this.clientInfoBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(719, 537);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 49);
            this.closeBtn.TabIndex = 92;
            this.closeBtn.Text = "Закрыть форму";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(607, 537);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 49);
            this.saveBtn.TabIndex = 91;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // directorComboBox
            // 
            this.directorComboBox.DataSource = this.employeesBindingSource;
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(268, 491);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(526, 21);
            this.directorComboBox.TabIndex = 90;
            this.directorComboBox.ValueMember = "EmployeeId";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.suetaDataSet;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(268, 217);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(526, 20);
            this.addressTextBox.TabIndex = 85;
            // 
            // restaurantTitleTextBox
            // 
            this.restaurantTitleTextBox.Location = new System.Drawing.Point(268, 117);
            this.restaurantTitleTextBox.Name = "restaurantTitleTextBox";
            this.restaurantTitleTextBox.Size = new System.Drawing.Size(526, 20);
            this.restaurantTitleTextBox.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Директор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Время закрытия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Время открытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Дата основания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Название ресторана";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 42);
            this.label1.TabIndex = 74;
            this.label1.Text = "Юридические данные";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(268, 173);
            this.phoneTextBox.Mask = "(999) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(526, 20);
            this.phoneTextBox.TabIndex = 95;
            // 
            // INNTextBox
            // 
            this.INNTextBox.Location = new System.Drawing.Point(268, 276);
            this.INNTextBox.Mask = "0000000000";
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.Size = new System.Drawing.Size(526, 20);
            this.INNTextBox.TabIndex = 96;
            // 
            // foundationDateTimePicker
            // 
            this.foundationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.foundationDateTimePicker.Location = new System.Drawing.Point(268, 330);
            this.foundationDateTimePicker.Name = "foundationDateTimePicker";
            this.foundationDateTimePicker.Size = new System.Drawing.Size(526, 20);
            this.foundationDateTimePicker.TabIndex = 97;
            // 
            // openingDateTimePicker
            // 
            this.openingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.openingDateTimePicker.Location = new System.Drawing.Point(268, 385);
            this.openingDateTimePicker.Name = "openingDateTimePicker";
            this.openingDateTimePicker.Size = new System.Drawing.Size(526, 20);
            this.openingDateTimePicker.TabIndex = 98;
            // 
            // closingDateTimePicker
            // 
            this.closingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.closingDateTimePicker.Location = new System.Drawing.Point(268, 440);
            this.closingDateTimePicker.Name = "closingDateTimePicker";
            this.closingDateTimePicker.Size = new System.Drawing.Size(526, 20);
            this.closingDateTimePicker.TabIndex = 99;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // legalDataBindingSource
            // 
            this.legalDataBindingSource.DataMember = "LegalData";
            this.legalDataBindingSource.DataSource = this.suetaDataSet;
            // 
            // legalDataTableAdapter
            // 
            this.legalDataTableAdapter.ClearBeforeFill = true;
            // 
            // LegalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 665);
            this.Controls.Add(this.closingDateTimePicker);
            this.Controls.Add(this.openingDateTimePicker);
            this.Controls.Add(this.foundationDateTimePicker);
            this.Controls.Add(this.INNTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clientInfoBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.restaurantTitleTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LegalDataForm";
            this.Text = "LegalDataForm";
            this.Load += new System.EventHandler(this.LegalDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button clientInfoBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox restaurantTitleTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.MaskedTextBox INNTextBox;
        private System.Windows.Forms.DateTimePicker foundationDateTimePicker;
        private System.Windows.Forms.DateTimePicker openingDateTimePicker;
        private System.Windows.Forms.DateTimePicker closingDateTimePicker;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private suetaDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource legalDataBindingSource;
        private suetaDataSetTableAdapters.LegalDataTableAdapter legalDataTableAdapter;
    }
}