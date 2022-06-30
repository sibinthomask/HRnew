using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeRegistration
    {
        /// <summary>
        /// Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        /// </summary>
        public long EmployeeId { get; set; }
        public byte[]? Picture { get; set; }
        public string? PicturePath { get; set; }
        public string? EmpUsername { get; set; }
        public string? EmpPassword { get; set; }
        /// <summary>
        /// Work title such as Buyer or Sales Representative.
        /// </summary>
        public long? DesignationId { get; set; }
        public long? DepartmentId { get; set; }
        /// <summary>
        /// Employee hired on this date.
        /// </summary>
        public DateTime? HireDate { get; set; }
        /// <summary>
        /// Unique national identification number such as a social security number.
        /// </summary>
        public string? EmpName { get; set; }
        public string? EmpIdno { get; set; }
        /// <summary>
        /// Network login.
        /// </summary>
        public string? EmpGender { get; set; }
        /// <summary>
        /// Where the employee is located in corporate hierarchy.
        /// </summary>
        public string? ContactAddress { get; set; }
        public string? ContactNumber { get; set; }
        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime? Dob { get; set; }
        /// <summary>
        /// M = Married, S = Single
        /// </summary>
        public string? MaritalStatus { get; set; }
        public string? BloodGroup { get; set; }
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
        public int? Status { get; set; }
    }
}
