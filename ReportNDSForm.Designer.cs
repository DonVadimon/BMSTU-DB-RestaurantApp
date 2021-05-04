
namespace kursologV2
{
    partial class ReportNDSForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.suetaDataSet = new kursologV2.suetaDataSet();
            this.DishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DishesTableAdapter = new kursologV2.suetaDataSetTableAdapters.DishesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DishesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NDSDataSet";
            reportDataSource1.Value = this.DishesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursologV2.ReportNDS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // suetaDataSet
            // 
            this.suetaDataSet.DataSetName = "suetaDataSet";
            this.suetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DishesBindingSource
            // 
            this.DishesBindingSource.DataMember = "Dishes";
            this.DishesBindingSource.DataSource = this.suetaDataSet;
            // 
            // DishesTableAdapter
            // 
            this.DishesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportNDSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportNDSForm";
            this.Text = "ReportNDSForm";
            this.Load += new System.EventHandler(this.ReportNDSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DishesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DishesBindingSource;
        private suetaDataSet suetaDataSet;
        private suetaDataSetTableAdapters.DishesTableAdapter DishesTableAdapter;
    }
}