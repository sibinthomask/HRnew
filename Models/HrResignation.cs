using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrResignation
    {
        public int ResignationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? AppliedDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public int? NoticePeriod { get; set; }
        public string? ResignationType { get; set; }
        public DateTime? RequestedLastWorkingDate { get; set; }
        public DateTime? ActualLastWorkingDate { get; set; }
        public DateTime? ShortfallDate { get; set; }
        public decimal? ShortfallAmount { get; set; }
        public string? Reason { get; set; }
        public string? Comments { get; set; }
        public string? ResignationStatus { get; set; }
    }
}
