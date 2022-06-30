using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeFamilyBackground
    {
        public int FamilyBackgroundId { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? SpouseName { get; set; }
        public int? Children { get; set; }
        public string? UrgentContactNumber1 { get; set; }
        public string? UrgentContactNumber2 { get; set; }
        public string? PermanentAddress { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime? RegDate { get; set; }
        public long? RegBy { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiledBy { get; set; }
    }
}
