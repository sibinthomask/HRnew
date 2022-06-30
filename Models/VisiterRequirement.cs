using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class VisiterRequirement
    {
        public int TaskId { get; set; }
        public int? DeptId { get; set; }
        public int? AssignedToVisiterId { get; set; }
        public string? VisiterTask { get; set; }
        public string? TaskType { get; set; }
        public string? TaskDetails { get; set; }
        /// <summary>
        /// ToDo to Normal to Moderate to High to Overdue to Deployed
        /// </summary>
        public int? TaskStatus { get; set; }
        public TimeSpan? TimeDuration { get; set; }
        public DateTime? RegDate { get; set; }
        public int? RegUsr { get; set; }
        public DateTime? UptDate { get; set; }
        public int? UptUsr { get; set; }
    }
}
