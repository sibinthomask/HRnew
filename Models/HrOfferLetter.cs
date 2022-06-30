using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrOfferLetter
    {
        public int OfferLetterId { get; set; }
        public int? UserId { get; set; }
        public string? PostApplied { get; set; }
        public DateTime? ExpectedJoiningDate { get; set; }
        public decimal? OfferedSalary { get; set; }
        public string? Status { get; set; }
    }
}
