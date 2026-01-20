using System;

namespace ProjectTimeCalculator
{
    public class EmployeeTimesheet
    {
        public int EmployeeId { get; set; }
        private int workingDays = 0;
        public int WorkingDays
        {
            get
            {
                return workingDays;
            }
        }

        public void AddWorkingHours(DateTime dateFrom, DateTime? dateTo)
        {
            DateTime dateTimeTo = DateTime.Today;
            if (dateTo != null)
            {
                dateTimeTo = dateTo.Value;
            }
            TimeSpan timeSpan = dateTimeTo - dateFrom;
            workingDays = workingDays + timeSpan.Days + 1;
        }
    }
}
