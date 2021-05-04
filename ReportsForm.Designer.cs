
namespace kursologV2
{
    partial class ReportsForm
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
            this.productsListBtn = new System.Windows.Forms.Button();
            this.tablesListBtn = new System.Windows.Forms.Button();
            this.NDSForeachDishBtn = new System.Windows.Forms.Button();
            this.dishesListBtn = new System.Windows.Forms.Button();
            this.employeesListBtn = new System.Windows.Forms.Button();
            this.providersListBtn = new System.Windows.Forms.Button();
            this.positionsListBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsListBtn
            // 
            this.productsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsListBtn.Location = new System.Drawing.Point(188, 275);
            this.productsListBtn.Name = "productsListBtn";
            this.productsListBtn.Size = new System.Drawing.Size(134, 59);
            this.productsListBtn.TabIndex = 23;
            this.productsListBtn.Text = "Продукты на складе";
            this.productsListBtn.UseVisualStyleBackColor = true;
            // 
            // tablesListBtn
            // 
            this.tablesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesListBtn.Location = new System.Drawing.Point(38, 275);
            this.tablesListBtn.Name = "tablesListBtn";
            this.tablesListBtn.Size = new System.Drawing.Size(134, 59);
            this.tablesListBtn.TabIndex = 22;
            this.tablesListBtn.Text = "Столики";
            this.tablesListBtn.UseVisualStyleBackColor = true;
            this.tablesListBtn.Click += new System.EventHandler(this.tablesListBtn_Click);
            // 
            // NDSForeachDishBtn
            // 
            this.NDSForeachDishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDSForeachDishBtn.Location = new System.Drawing.Point(188, 188);
            this.NDSForeachDishBtn.Name = "NDSForeachDishBtn";
            this.NDSForeachDishBtn.Size = new System.Drawing.Size(134, 59);
            this.NDSForeachDishBtn.TabIndex = 21;
            this.NDSForeachDishBtn.Text = "НДС для каждого блюда";
            this.NDSForeachDishBtn.UseVisualStyleBackColor = true;
            this.NDSForeachDishBtn.Click += new System.EventHandler(this.NDSForeachDishBtn_Click);
            // 
            // dishesListBtn
            // 
            this.dishesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishesListBtn.Location = new System.Drawing.Point(188, 98);
            this.dishesListBtn.Name = "dishesListBtn";
            this.dishesListBtn.Size = new System.Drawing.Size(134, 59);
            this.dishesListBtn.TabIndex = 20;
            this.dishesListBtn.Text = "Меню Ресторана";
            this.dishesListBtn.UseVisualStyleBackColor = true;
            this.dishesListBtn.Click += new System.EventHandler(this.dishesListBtn_Click);
            // 
            // employeesListBtn
            // 
            this.employeesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeesListBtn.Location = new System.Drawing.Point(188, 29);
            this.employeesListBtn.Name = "employeesListBtn";
            this.employeesListBtn.Size = new System.Drawing.Size(134, 59);
            this.employeesListBtn.TabIndex = 19;
            this.employeesListBtn.Text = "Список сотрудников";
            this.employeesListBtn.UseVisualStyleBackColor = true;
            this.employeesListBtn.Click += new System.EventHandler(this.employeesListBtn_Click);
            // 
            // providersListBtn
            // 
            this.providersListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providersListBtn.Location = new System.Drawing.Point(38, 188);
            this.providersListBtn.Name = "providersListBtn";
            this.providersListBtn.Size = new System.Drawing.Size(134, 59);
            this.providersListBtn.TabIndex = 18;
            this.providersListBtn.Text = "Поставщики";
            this.providersListBtn.UseVisualStyleBackColor = true;
            this.providersListBtn.Click += new System.EventHandler(this.providersListBtn_Click);
            // 
            // positionsListBtn
            // 
            this.positionsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionsListBtn.Location = new System.Drawing.Point(38, 98);
            this.positionsListBtn.Name = "positionsListBtn";
            this.positionsListBtn.Size = new System.Drawing.Size(134, 59);
            this.positionsListBtn.TabIndex = 17;
            this.positionsListBtn.Text = "Должности";
            this.positionsListBtn.UseVisualStyleBackColor = true;
            this.positionsListBtn.Click += new System.EventHandler(this.positionsListBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(38, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 59);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 375);
            this.Controls.Add(this.productsListBtn);
            this.Controls.Add(this.tablesListBtn);
            this.Controls.Add(this.NDSForeachDishBtn);
            this.Controls.Add(this.dishesListBtn);
            this.Controls.Add(this.employeesListBtn);
            this.Controls.Add(this.providersListBtn);
            this.Controls.Add(this.positionsListBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productsListBtn;
        private System.Windows.Forms.Button tablesListBtn;
        private System.Windows.Forms.Button NDSForeachDishBtn;
        private System.Windows.Forms.Button dishesListBtn;
        private System.Windows.Forms.Button employeesListBtn;
        private System.Windows.Forms.Button providersListBtn;
        private System.Windows.Forms.Button positionsListBtn;
        private System.Windows.Forms.Button backBtn;
    }
}