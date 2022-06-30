using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeLeave
    {
        public int EmpLeaveId { get; set; }
        public int? EmpId { get; set; }
        public decimal? LeaveBalance { get; set; }
        /// <summary>
        /// Paid,Normal
        /// </summary>
        public string? LeaveType { get; set; }
        public string? LeaveReason { get; set; }
        public DateTime? LeaveFrom { get; set; }
        public DateTime? LeaveTo { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public string? LeaveStatus { get; set; }
    }
}
