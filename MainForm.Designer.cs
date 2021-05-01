
namespace kursologV2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.suetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.exitBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.formsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // suetaBindingSource
            // 
            this.suetaBindingSource.DataSource = this.suetaDataSet;
            this.suetaBindingSource.Position = 0;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(308, 326);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(142, 57);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Location = new System.Drawing.Point(644, 240);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(142, 57);
            this.infoBtn.TabIndex = 13;
            this.infoBtn.Text = "Инфо";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsBtn.Location = new System.Drawing.Point(308, 240);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(142, 57);
            this.reportsBtn.TabIndex = 12;
            this.reportsBtn.Text = "Отчеты";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // formsBtn
            // 
            this.formsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formsBtn.Location = new System.Drawing.Point(17, 241);
            this.formsBtn.Name = "formsBtn";
            this.formsBtn.Size = new System.Drawing.Size(142, 57);
            this.formsBtn.TabIndex = 11;
            this.formsBtn.Text = "Формы";
            this.formsBtn.UseVisualStyleBackColor = true;
            this.formsBtn.Click += new System.EventHandler(this.formsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "МЕНЮ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.formsBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource suetaBindingSource;
        private suetaDataSet suetaDataSet;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button formsBtn;
        private System.Windows.Forms.Label label1;
    }
}

