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
    public partial class ReportTablesForm : Form
    {
        public ReportTablesForm()
        {
            InitializeComponent();
        }

        private void ReportTablesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Tables". При необходимости она может быть перемещена или удалена.
            this.TablesTableAdapter.Fill(this.suetaDataSet._Tables);

            this.reportViewer1.RefreshReport();
        }
    }
}
