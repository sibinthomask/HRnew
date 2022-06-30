using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class StudentFee
    {
        public long StudFeeId { get; set; }
        public long? StudId { get; set; }
        public string? FeeType { get; set; }
        public decimal? FeeAmount { get; set; }
        public decimal? FeeAmountPaid { get; set; }
        public int? NumberOfInstallment { get; set; }
        public int? NumberOfInstallmentPaid { get; set; }
        public DateTime? FeePaidDate { get; set; }
        public long? FeeReceivedBy { get; set; }
    }
}
