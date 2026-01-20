using System;
using System.Windows.Forms;

namespace ProjectTimeCalculator
{
    public partial class Settings : Form
    {
        DataFormatService dataFormatSrv;
        public Settings()
        {
            InitializeComponent();
        }

        public void ShowByDataFormatService(DataFormatService dataFormatService)
        {
            dataFormatSrv = dataFormatService;
            ShowDialog();
        }

        private void SelectDateFormat_Click(object sender, EventArgs e)
        {
            dataFormatSrv.SelectedDateFormat = (string)EmployeeProjectsData.Rows[EmployeeProjectsData.SelectedCells[0].RowIndex].Cells[0].Value;
            Close();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            string[] dateFormats = dataFormatSrv.GetDateFormats();
            foreach (string dateFormat in dateFormats)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = dateFormat;
                row.Cells.Add(cell);

                EmployeeProjectsData.Rows.Add(row);
            }
        }

        private void EmployeeProjectsData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataFormatSrv.SelectedDateFormat = (string)EmployeeProjectsData.Rows[EmployeeProjectsData.SelectedCells[0].RowIndex].Cells[0].Value;
            Close();
        }
    }
}
