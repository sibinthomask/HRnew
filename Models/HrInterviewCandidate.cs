using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrInterviewCandidate
    {
        public int InterviewCandidateId { get; set; }
        public DateTime? ResumeHandoverDate { get; set; }
        public string? ResumeHandoverBy { get; set; }
        public DateTime? InterviewDate { get; set; }
        public decimal? TotalYearsExperience { get; set; }
        public decimal? RelevantYearsExperience { get; set; }
        public decimal? LastDrawnAnnualSalaryCtc { get; set; }
        public decimal? MonthlySalaryonJoining { get; set; }
        public string? DifferentlyAble { get; set; }
        public long? BankAccountNumber { get; set; }
        public string? Ifsc { get; set; }
        public byte[]? Resume { get; set; }
        public string? ResumePath { get; set; }
    }
}
