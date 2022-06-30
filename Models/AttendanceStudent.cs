using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class AttendanceStudent
    {

        public DateTime? Day { get; set; }
        public long StudAttendanceId { get; set; }
        public long? StudId { get; set; }
        public string? StudNumber { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public byte[]? Inphoto { get; set; }
        public byte[]? Outphoto { get; set; }
        public decimal? ExtraTimePerDay { get; set; }
        public string? Status { get; set; }
        public string? DailyMailStatus { get; set; }
    }
}
