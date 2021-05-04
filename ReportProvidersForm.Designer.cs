
namespace kursologV2
{
    partial class ReportProvidersForm
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
            this.ReportProvidersDataSet = new kursologV2.ReportProvidersDataSet();
            this.DataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTableAdapter = new kursologV2.ReportProvidersDataSetTableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportProvidersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportProvidersDS";
            reportDataSource1.Value = this.DataTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kursologV2.ReportProviders.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportProvidersDataSet
            // 
            this.ReportProvidersDataSet.DataSetName = "ReportProvidersDataSet";
            this.ReportProvidersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableBindingSource
            // 
            this.DataTableBindingSource.DataMember = "DataTable";
            this.DataTableBindingSource.DataSource = this.ReportProvidersDataSet;
            // 
            // DataTableTableAdapter
            // 
            this.DataTableTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportProvidersForm";
            this.Text = "ReportProvidersForm";
            this.Load += new System.EventHandler(this.ReportProvidersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportProvidersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableBindingSource;
        private ReportProvidersDataSet ReportProvidersDataSet;
        private ReportProvidersDataSetTableAdapters.DataTableTableAdapter DataTableTableAdapter;
    }
}