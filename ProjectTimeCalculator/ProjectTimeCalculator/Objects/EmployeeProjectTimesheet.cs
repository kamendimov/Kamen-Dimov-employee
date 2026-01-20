using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTimeCalculator
{
    public class EmployeeProjectTimesheet
    {
        private List<EmployeeTimesheet> employeeTimesheets = new List<EmployeeTimesheet>();
        public int ProjectId { get; set; }

        public void CreateEmployeeTimesheet(int employeeId, DateTime dateFrom, DateTime? dateTo)
        {
            EmployeeTimesheet employeeTimesheet = employeeTimesheets.Where(et => et.EmployeeId == employeeId).SingleOrDefault();
            if (employeeTimesheet == null)
            {
                employeeTimesheet = new EmployeeTimesheet();
                employeeTimesheet.EmployeeId = employeeId;
                employeeTimesheets.Add(employeeTimesheet);
            }
            employeeTimesheet.AddWorkingHours(dateFrom, dateTo);
        }

        public EmployeeTimesheet[] GetEmployeeByWorkingHoursDescending(int numEmployeePresented)
        {
            if (employeeTimesheets.Count >= numEmployeePresented)
            {
                EmployeeTimesheet[] timesheets = employeeTimesheets.OrderByDescending(emp => emp.WorkingDays).ToArray();
                return timesheets.Take(numEmployeePresented).ToArray();
            }
            return null;
        }
    }
}
