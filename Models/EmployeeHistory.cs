using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeHistory
    {
        public long EmployeeHisId { get; set; }
        public long? EmployeeId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? Designation { get; set; }
        public decimal? Experience { get; set; }
        public string? Status { get; set; }
        public long? HrcontactNumber { get; set; }
        public string? Hrcomments { get; set; }
    }
}
