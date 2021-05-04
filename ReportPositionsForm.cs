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
    public partial class ReportPositionsForm : Form
    {
        public ReportPositionsForm()
        {
            InitializeComponent();
        }

        private void ReportPositionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.PositionsTableAdapter.Fill(this.suetaDataSet.Positions);

            this.reportViewer1.RefreshReport();
        }
    }
}
