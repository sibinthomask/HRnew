using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeDailyTimesheet
    {
        public long TimesheetId { get; set; }
        public long? EmpId { get; set; }
        public long? TaskId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long? CommittedHours { get; set; }
        public string? TimesheetDetails { get; set; }
        public string? TimesheetEmpStatus { get; set; }
        public string? TimesheetHrStatus { get; set; }
    }
}
