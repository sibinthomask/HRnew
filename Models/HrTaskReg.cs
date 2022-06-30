using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrTaskReg
    {
        public int TaskId { get; set; }
        public string? TaskNo { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public long? DeptId { get; set; }
        public string? TaskStatus { get; set; }
        public DateTime? TaskRegDate { get; set; }
        public DateTime? TaskTargetDate { get; set; }
        public long? NoEmployees { get; set; }
    }
}
