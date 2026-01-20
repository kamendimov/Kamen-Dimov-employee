namespace ProjectTimeCalculator
{
    public class ProjectTimesheet
    {
        public int ProjectId;
        public EmployeeTimesheet[] employeeTimesheets;

        public int SumWorkingDays()
        {
            int workingDays = 0;
            foreach(EmployeeTimesheet timesheet in employeeTimesheets)
            {
                workingDays = workingDays + timesheet.WorkingDays;
            }
            return workingDays;
        }
    }
}
