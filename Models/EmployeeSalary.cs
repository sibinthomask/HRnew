using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeSalary
    {
        public long EmpSalId { get; set; }
        public long? DeptId { get; set; }
        public long? EmpId { get; set; }
        public long? MonthlyWorkingDays { get; set; }
        public decimal? SalaryAmount { get; set; }
        public string? SalaryStatus { get; set; }
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



        //public List<EmployeeSalary> EmployeeSalarys { get; set; }
        //public int CurrentPageIndex { get; set; }
        //public int PageCount { get; set; }
    }
}
