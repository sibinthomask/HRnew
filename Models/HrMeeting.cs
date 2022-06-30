using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrMeeting
    {
        public int MeetingId { get; set; }
        public DateTime? DateTime { get; set; }
        public string? MeetingType { get; set; }
        public string? MeetingHeading { get; set; }
        public string? MeetingDescription { get; set; }
        public int? MemberCount { get; set; }
        public string? Status { get; set; }
    }
}
