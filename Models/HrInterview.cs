using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrInterview
    {
        public int InterviewId { get; set; }
        public string? Interviewer { get; set; }
        public string? Interviewee { get; set; }
        public string? PositionFor { get; set; }
        public string? IntervieweeSkills { get; set; }
        public DateTime? IntervieweeDob { get; set; }
        public long? IntervieweeContactNumber { get; set; }
        public string? IntervieweeAddress { get; set; }
        public DateTime? InterviewDate { get; set; }
        public decimal? TheoryTime { get; set; }
        public decimal? PracticalTime { get; set; }
        public byte[]? InterviewStatus { get; set; }
    }
}
