using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrPageAccess
    {
        public int PageAccessId { get; set; }
        public string PageName { get; set; } = null!;
        public string PageHandledBy { get; set; } = null!;
    }
}
