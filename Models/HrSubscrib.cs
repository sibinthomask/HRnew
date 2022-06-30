using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrSubscrib
    {
        public int SubscribeId { get; set; }
        public int? Userid { get; set; }
        public string? SubscribeSubject { get; set; }
        public string? SubscribeDescription { get; set; }
        public string? FullName { get; set; }
        public string? Mailid { get; set; }
        public DateTime? SubscribeDateTime { get; set; }
        public string? SubscribeStatus { get; set; }
    }
}
