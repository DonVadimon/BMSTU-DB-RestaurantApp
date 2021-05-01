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
    public partial class LegalDataForm : Form
    {
        private static class LegalDataModel
        {
            public static string restaurantTitle { get; set; }
            public static string phone { get; set; }
            public static string address { get; set; }
            public static int INN { get; set; }
            public static DateTime foundationDate { get; set; }
            public static DateTime openigTime { get; set; }
            public static DateTime closingTime { get; set; }
            public static int directorId { get; set; }

            public static void reset(suetaDataSet.LegalDataRow oldlData)
            {
                restaurantTitle = oldlData.RestourantTitle;
                phone = oldlData.Phone;
                address = oldlData.Address;
                INN = oldlData.INN;
                foundationDate = oldlData.FoundationDate;
                openigTime = oldlData.OpeningTime;
                closingTime = oldlData.ClosingTime;
                directorId = oldlData.DirectorId;
            }
        }

        public LegalDataForm()
        {
            InitializeComponent();
        }

        private void LegalDataForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.LegalData". При необходимости она может быть перемещена или удалена.
            this.legalDataTableAdapter.Fill(this.suetaDataSet.LegalData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suetaDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.suetaDataSet.Employees);
            List<string> directors = employeesTableAdapter.GetData().Where(emp => emp.PositionId == 2).Select(emp => emp.FullName).ToList<string>();
            directorComboBox.DataSource = directors;
            var legalData = legalDataTableAdapter.GetData().FirstOrDefault(ld => ld.RestourantTitle != "");
            LegalDataModel.reset(legalData);
            clearInputs();
        }

        private void updateView()
        {
            legalDataTableAdapter.Fill(suetaDataSet.LegalData);
            legalDataBindingSource.ResetBindings(false);
        }

        private void updateRow()
        {
            legalDataTableAdapter.Update(restaurantTitleTextBox.Text, phoneTextBox.Text, addressTextBox.Text, Convert.ToInt32(INNTextBox.Text),
                foundationDateTimePicker.Value, openingDateTimePicker.Value, closingDateTimePicker.Value,
                LegalDataModel.restaurantTitle, LegalDataModel.phone, LegalDataModel.address, LegalDataModel.INN, LegalDataModel.foundationDate,
                LegalDataModel.openigTime, LegalDataModel.closingTime, LegalDataModel.directorId);
        }

        private void clearInputs()
        {
            var legalData = legalDataTableAdapter.GetData().FirstOrDefault(ld => ld.RestourantTitle != "");
            restaurantTitleTextBox.Text = legalData.RestourantTitle;
            phoneTextBox.Text = legalData.Phone;
            addressTextBox.Text = legalData.Address;
            INNTextBox.Text = legalData.INN.ToString();
            foundationDateTimePicker.Value = legalData.FoundationDate;
            openingDateTimePicker.Value = legalData.OpeningTime;
            closingDateTimePicker.Value = legalData.ClosingTime;
        }

        private bool isIncorrectInputs()
        {
            return restaurantTitleTextBox.Text == "" || phoneTextBox.Text.Length < 15 || addressTextBox.Text == "" || INNTextBox.Text.Length < 10;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Некорректные данные");
            }
            else
            {
                updateRow();
                updateView();
                var legalData = legalDataTableAdapter.GetData().FirstOrDefault(ld => ld.RestourantTitle != "");
                LegalDataModel.reset(legalData);
                clearInputs();
            }
        }
    }
}
