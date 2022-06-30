using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class StudentProject
    {
        public long StudProjectId { get; set; }
        public long? StudId { get; set; }
        public string? StudProjectName { get; set; }
        public string? StudProjectTechnologies { get; set; }
        public string? StudProjectDescription { get; set; }
        public int? StudProjectAssignedTo { get; set; }
        public DateTime? StudProjectStartDate { get; set; }
        public DateTime? StudProjectCompletionDate { get; set; }
        public string? StudProjectPath { get; set; }
        public string? StudProjectStatus { get; set; }
    }
}
