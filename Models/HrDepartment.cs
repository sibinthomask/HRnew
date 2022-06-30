using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrDepartment
    {
        /// <summary>
        /// Primary key for Department records.
        /// </summary>
        public long DepartmentId { get; set; }
        /// <summary>
        /// Name of the department.
        /// </summary>
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public long? Hod { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiledBy { get; set; }
        public int Status { get; set; }
    }
}
