using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrDesignation
    {
        public long DesignationId { get; set; }
        public string? Designation { get; set; }
        public string? DutiesAssigned { get; set; }
    }
}
