
namespace kursologV2
{
    partial class StuffFromsForm
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
            this.productsBtn = new System.Windows.Forms.Button();
            this.providersBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.unitsBtn = new System.Windows.Forms.Button();
            this.dishesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(49, 359);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 49);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(49, 288);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(126, 49);
            this.productsBtn.TabIndex = 16;
            this.productsBtn.Text = "Склад";
            this.productsBtn.UseVisualStyleBackColor = true;
            // 
            // providersBtn
            // 
            this.providersBtn.Location = new System.Drawing.Point(49, 219);
            this.providersBtn.Name = "providersBtn";
            this.providersBtn.Size = new System.Drawing.Size(126, 49);
            this.providersBtn.TabIndex = 15;
            this.providersBtn.Text = "Поставщики";
            this.providersBtn.UseVisualStyleBackColor = true;
            this.providersBtn.Click += new System.EventHandler(this.providersBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.Location = new System.Drawing.Point(49, 148);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(126, 49);
            this.ordersBtn.TabIndex = 14;
            this.ordersBtn.Text = "Заказ";
            this.ordersBtn.UseVisualStyleBackColor = true;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // unitsBtn
            // 
            this.unitsBtn.Location = new System.Drawing.Point(49, 86);
            this.unitsBtn.Name = "unitsBtn";
            this.unitsBtn.Size = new System.Drawing.Size(126, 49);
            this.unitsBtn.TabIndex = 13;
            this.unitsBtn.Text = "Единицы измерения";
            this.unitsBtn.UseVisualStyleBackColor = true;
            this.unitsBtn.Click += new System.EventHandler(this.unitsBtn_Click);
            // 
            // dishesBtn
            // 
            this.dishesBtn.Location = new System.Drawing.Point(49, 22);
            this.dishesBtn.Name = "dishesBtn";
            this.dishesBtn.Size = new System.Drawing.Size(126, 49);
            this.dishesBtn.TabIndex = 12;
            this.dishesBtn.Text = "Блюда";
            this.dishesBtn.UseVisualStyleBackColor = true;
            this.dishesBtn.Click += new System.EventHandler(this.dishesBtn_Click);
            // 
            // StuffFromsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.providersBtn);
            this.Controls.Add(this.ordersBtn);
            this.Controls.Add(this.unitsBtn);
            this.Controls.Add(this.dishesBtn);
            this.Name = "StuffFromsForm";
            this.Text = "StuffFromsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button providersBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button unitsBtn;
        private System.Windows.Forms.Button dishesBtn;
    }
}