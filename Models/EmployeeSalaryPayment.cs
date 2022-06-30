using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeSalaryPayment
    {
        public long EmpSalId { get; set; }
        public long? DeptId { get; set; }
        public long? EmpId { get; set; }
        public DateTime? SalaryPaidYearMonth { get; set; }
        public long? MonthlyWorkingDays { get; set; }
        public decimal? SalaryPaidAmount { get; set; }
        public decimal? SalAdvancePaidAmount { get; set; }
        public DateTime? SalAdvancePaidDate { get; set; }
        public string? SalAdvancePaidStatus { get; set; }
        public string? SalPaidStatus { get; set; }
        public DateTime? SalPaidDate { get; set; }
        public long? SalPaidRegBy { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiledBy { get; set; }
    }
}
