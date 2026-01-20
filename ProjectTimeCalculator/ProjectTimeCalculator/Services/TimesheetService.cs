using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace ProjectTimeCalculator
{
    public class TimesheetService
    {
        private List<EmployeeProjectTimesheet> employees = new List<EmployeeProjectTimesheet>();

        public CREATE_OBJECT_RESULT CreateEmployeeProjectTimesheet(
            string selDateFormat, string projectIdStr, string employeeIdStr, string dateFromStr, string dateToStr)
        {
            int projectId;
            if (!int.TryParse(projectIdStr, out projectId))
            {
                return CREATE_OBJECT_RESULT.INVALID_PROJECT_ID;
            }
            int employeeId;
            if (!int.TryParse(employeeIdStr, out employeeId))
            {
                return CREATE_OBJECT_RESULT.INVALID_EMPLOYEE_ID;
            }
            DateTime dateFrom = DateTime.Today;
            if (!DateTime.TryParseExact(dateFromStr, selDateFormat, CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out dateFrom))
            {
                return CREATE_OBJECT_RESULT.INVALID_DATE_FROM;
            }
            DateTime? dateTo = null;
            DateTime dateToVal = DateTime.Today;
            if (dateToStr.Equals("NULL") || dateToStr.Equals("null"))
            {
                dateTo = null;
            }
            else if (!DateTime.TryParseExact(dateToStr, selDateFormat, CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out dateToVal))
            {
                return CREATE_OBJECT_RESULT.INVALID_DATE_TO;
            }
            dateTo = dateToVal;
            if ((dateTo.HasValue && dateTo < dateFrom) || (dateFrom > DateTime.Today))
            {
                return CREATE_OBJECT_RESULT.INVALID_DATE_TO_BEFORE_DATE_FROM;
            }
            EmployeeProjectTimesheet employeeProject = employees.Where(ept => ept.ProjectId == projectId).SingleOrDefault();
            if (employeeProject == null)
            {
                employeeProject = new EmployeeProjectTimesheet();
                employeeProject.ProjectId = projectId;
                employees.Add(employeeProject);
            }
            employeeProject.CreateEmployeeTimesheet(employeeId, dateFrom, dateTo);
            return CREATE_OBJECT_RESULT.SUCCESS;
        }

        public ProjectTimesheet[] OrderCreatedObjectsByNumberOfEmployee(int numEmployeePresented)
        {
            List<ProjectTimesheet> employeesTimesheets = new List<ProjectTimesheet>();
            foreach(EmployeeProjectTimesheet employeeProject in employees)
            {
                EmployeeTimesheet[] timesheets = employeeProject.GetEmployeeByWorkingHoursDescending(numEmployeePresented);
                if (timesheets != null)
                {
                    ProjectTimesheet projectTimesheet = new ProjectTimesheet();
                    projectTimesheet.ProjectId = employeeProject.ProjectId;
                    projectTimesheet.employeeTimesheets = timesheets;
                    employeesTimesheets.Add(projectTimesheet);
                }
            }
            return employeesTimesheets.ToArray();
        }
    }
}

public enum CREATE_OBJECT_RESULT
{
    [Description("")]
    SUCCESS = 1,

    [Description("Невалидна стойност за Project Id!")]
    INVALID_PROJECT_ID = 2,

    [Description("Невалидна стойност за Employee Id!")]
    INVALID_EMPLOYEE_ID = 3,

    [Description("Невалидна стойност за начална дата!")]
    INVALID_DATE_FROM = 4,

    [Description("Невалидна стойност за крайна дата!")]
    INVALID_DATE_TO = 5,

    [Description("Невалидна структура от данни!")]
    INVALID_DATA_STRUCTURE = 6,

    [Description("Началната дата не може да бъде след крайната дата!")]
    INVALID_DATE_TO_BEFORE_DATE_FROM = 7
}