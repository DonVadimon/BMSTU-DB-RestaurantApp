
namespace kursologV2
{
    partial class AdminFormsFrom
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
            this.backBtn = new System.Windows.Forms.Button();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.legalDataBtn = new System.Windows.Forms.Button();
            this.employeesBtn = new System.Windows.Forms.Button();
            this.positionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(45, 327);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(149, 54);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tablesBtn
            // 
            this.tablesBtn.Location = new System.Drawing.Point(45, 253);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(149, 54);
            this.tablesBtn.TabIndex = 13;
            this.tablesBtn.Text = "Столики";
            this.tablesBtn.UseVisualStyleBackColor = true;
            // 
            // legalDataBtn
            // 
            this.legalDataBtn.Location = new System.Drawing.Point(45, 176);
            this.legalDataBtn.Name = "legalDataBtn";
            this.legalDataBtn.Size = new System.Drawing.Size(149, 54);
            this.legalDataBtn.TabIndex = 12;
            this.legalDataBtn.Text = "Юридические данные";
            this.legalDataBtn.UseVisualStyleBackColor = true;
            // 
            // employeesBtn
            // 
            this.employeesBtn.Location = new System.Drawing.Point(45, 105);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(149, 54);
            this.employeesBtn.TabIndex = 11;
            this.employeesBtn.Text = "Сотрудники";
            this.employeesBtn.UseVisualStyleBackColor = true;
            // 
            // positionsBtn
            // 
            this.positionsBtn.Location = new System.Drawing.Point(45, 37);
            this.positionsBtn.Name = "positionsBtn";
            this.positionsBtn.Size = new System.Drawing.Size(149, 54);
            this.positionsBtn.TabIndex = 10;
            this.positionsBtn.Text = "Должности";
            this.positionsBtn.UseVisualStyleBackColor = true;
            this.positionsBtn.Click += new System.EventHandler(this.positionsBtn_Click);
            // 
            // AdminFormsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.tablesBtn);
            this.Controls.Add(this.legalDataBtn);
            this.Controls.Add(this.employeesBtn);
            this.Controls.Add(this.positionsBtn);
            this.Name = "AdminFormsFrom";
            this.Text = "AdminFormsFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button tablesBtn;
        private System.Windows.Forms.Button legalDataBtn;
        private System.Windows.Forms.Button employeesBtn;
        private System.Windows.Forms.Button positionsBtn;
    }
}