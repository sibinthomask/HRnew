using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class EmployeeCertificateVerification
    {
        public int CertificateVerificationId { get; set; }
        public int? EmpId { get; set; }
        public string? Description { get; set; }
        public int? VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string? Status { get; set; }
    }
}
