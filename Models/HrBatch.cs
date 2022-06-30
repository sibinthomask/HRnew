using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrBatch
    {
        public long BatchId { get; set; }
        public string? BatchName { get; set; }
        public long? ParticipantsNumber { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public long? TuterEmpId { get; set; }
    }
}
