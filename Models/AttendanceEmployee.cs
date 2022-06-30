using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class AttendanceEmployee
    {
        public DateTime? Day { get; set; }
        public long EmpAttendanceId { get; set; }
        public long? EmpId { get; set; }
        public string? EmpNumber { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public byte[]? Inphoto { get; set; }
        public byte[]? Outphoto { get; set; }
        public decimal? ExtraTimePerDay { get; set; }
        public string? Status { get; set; }
        public string? DailyMailStatus { get; set; }
    }
}
