using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrFeedback
    {
        public int FeedbackId { get; set; }
        public int? FeedbackRegBy { get; set; }
        public DateTime? RegDate { get; set; }
        public string? FeedbackAbout { get; set; }
        public string? FeedbackDescription { get; set; }
        public string? Status { get; set; }
    }
}
