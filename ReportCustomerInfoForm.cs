using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursologV2
{
    public partial class ReportCustomerInfoForm : Form
    {
        public ReportCustomerInfoForm()
        {
            InitializeComponent();
        }

        private void ReportCustomerInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.LegalData". При необходимости она может быть перемещена или удалена.
            this.LegalDataTableAdapter.Fill(this.suetaDataSet.LegalData);

            this.reportViewer1.RefreshReport();
        }
    }
}
