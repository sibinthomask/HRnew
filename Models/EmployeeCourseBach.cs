using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeCourseBach
    {
        public long EmpCourseBachId { get; set; }
        public long? CourseId { get; set; }
        public long? Bach { get; set; }
        public long? EmpId { get; set; }
        public DateTime? EmpCourseBachRegDate { get; set; }
        public long? EmpCourseBachRegBy { get; set; }
        public string? EmpCourseBachStatus { get; set; }
    }
}
