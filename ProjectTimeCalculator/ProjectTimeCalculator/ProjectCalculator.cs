using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ProjectTimeCalculator
{
    public partial class ProjectCalculator : Form
    {
        private const int EMPLOYEE_CSV_INDEX = 0;
        private const int PROJECT_CSV_INDEX = 1;
        private const int DATE_FROM_CSV_INDEX = 2;
        private const int DATE_TO_CSV_INDEX = 3;
        private const int NUM_EMPLOYEE_PRESENTED = 2;

        private string InitialDirectory;
        private DataFormatService dataFormatService;
        public ProjectCalculator()
        {
            InitializeComponent();
            InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFormatService = new DataFormatService();
        }

        private void LoadCSVFile_Click(object sender, EventArgs e)
        {
            string [] exts = { "csv" };
            string selectedFile = OpenFileDialogByFileType(exts, true);
            if (selectedFile != null && File.Exists(selectedFile))
            {
                string[] csvs = File.ReadAllLines(selectedFile);
                CREATE_OBJECT_RESULT result = ProcessData(csvs);
                if (result != CREATE_OBJECT_RESULT.SUCCESS)
                {
                    string msg = ((DescriptionAttribute)result.GetType().GetTypeInfo().GetField(result.ToString()).
                        GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description;
                    MessageBox.Show(msg);
                }
            }
        }

        private void SelectDateFormat_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowByDataFormatService(dataFormatService);
        }

        private CREATE_OBJECT_RESULT ProcessData(string[] csvs)
        {
            TimesheetService timesheetService = new TimesheetService();
            for (int q = 1; q < csvs.Length; q++)
            {
                string[] values = csvs[q].Split(',');
                if (values.Length != 4)
                {
                    return CREATE_OBJECT_RESULT.INVALID_DATA_STRUCTURE;
                }
                CREATE_OBJECT_RESULT result = timesheetService.CreateEmployeeProjectTimesheet(
                    dataFormatService.SelectedDateFormat, values[PROJECT_CSV_INDEX], values[EMPLOYEE_CSV_INDEX], 
                    values[DATE_FROM_CSV_INDEX], values[DATE_TO_CSV_INDEX]);

                if(result != CREATE_OBJECT_RESULT.SUCCESS)
                {
                    return result;
                }
            }
            ProjectTimesheet[] timesheets = timesheetService.OrderCreatedObjectsByNumberOfEmployee(NUM_EMPLOYEE_PRESENTED);
            PresentInGridView(timesheets);
            return CREATE_OBJECT_RESULT.SUCCESS;
        }

        private void PresentInGridView(ProjectTimesheet[] timesheets)
        {
            EmployeeProjectsData.Columns.Clear();
            EmployeeProjectsData.Rows.Clear();

            DataGridViewColumn column;
            for (int q = 1; q <= NUM_EMPLOYEE_PRESENTED; q++)
            {
                column = new DataGridViewColumn();
                column.Width = 200;
                column.Name = "EmployeeId" + q;
                column.HeaderText = "Employee Id # " + q;
                EmployeeProjectsData.Columns.Add(column);
            }
            column = new DataGridViewColumn();
            column.Width = 200;
            column.Name = "ProjectId";
            column.HeaderText = "Project Id";
            EmployeeProjectsData.Columns.Add(column);

            column = new DataGridViewColumn();
            column.Width = 200;
            column.Name = "WorkingDays";
            column.HeaderText = "Working Days";
            EmployeeProjectsData.Columns.Add(column);

            foreach (ProjectTimesheet timesheet in timesheets)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell;
                foreach (EmployeeTimesheet employeeTimesheet in timesheet.employeeTimesheets)
                {
                    cell = new DataGridViewTextBoxCell();
                    cell.Value = employeeTimesheet.EmployeeId;
                    row.Cells.Add(cell);
                }
                cell = new DataGridViewTextBoxCell();
                cell.Value = timesheet.ProjectId;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = timesheet.SumWorkingDays();
                row.Cells.Add(cell);
                EmployeeProjectsData.Rows.Add(row);
            }
        }

        protected string OpenFileDialogByFileType(string[] exts, bool doesIncludeAll)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = InitialDirectory;

            if (exts.Length > 0)
            {
                openFileDialog.Filter = exts[0] + " files (*." + exts[0] + ")|*." + exts[0];
                for (int q = 1; q < exts.Length; q++)
                {
                    openFileDialog.Filter = openFileDialog.Filter + "|" + exts[q] + " files (*." + exts[q] + ")|*." + exts[q];
                }
            }
            if (doesIncludeAll || exts.Length == 0)
            {
                if (exts.Length == 0)
                {
                    openFileDialog.Filter = "All files (*.*)|*.*";
                }
                else
                {
                    openFileDialog.Filter = openFileDialog.Filter + "|All files (*.*)|*.*";
                }
            }

            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (InitialDirectory.Length == 0 || !InitialDirectory.Equals(openFileDialog.FileName))
                {
                    InitialDirectory = openFileDialog.FileName;
                }
                return openFileDialog.FileName;
            }
            return string.Empty;
        }
    }
}
