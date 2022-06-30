using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class StudentRegistration
    {
        public long StudId { get; set; }
        public string? StudNumber { get; set; }
        public string? StudName { get; set; }
        public string? StudAddress { get; set; }
        public string? StudGender { get; set; }
        public DateTime? StudDob { get; set; }
        public long? CourseId { get; set; }
        public long? BachId { get; set; }
        public long? ContactNumber { get; set; }
        public long? ParentContactNumber { get; set; }
        public string? StudStatus { get; set; }
        public DateTime? StudRegDate { get; set; }
        public long? StudRegBy { get; set; }
        public DateTime? StudUpdtDate { get; set; }
        public long? StudUpdtBy { get; set; }
    }
}
