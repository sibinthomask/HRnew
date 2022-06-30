using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrCourse
    {
        public long CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDuration { get; set; }
        public string? CourseDescription { get; set; }
        public decimal? CourseFee { get; set; }
        public string? CourseStatus { get; set; }
        public DateTime? CourseRegDate { get; set; }
        public long? CourseegBy { get; set; }
    }
}
