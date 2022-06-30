using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class VisiterRegistration
    {
        public int UsrId { get; set; }
        public int? HandledBy { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? VisiterFullName { get; set; }
        public string? VisiterAddress { get; set; }
        public string? VisiterPurpose { get; set; }
        public bool? VisiterInGroup { get; set; }
        public int? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public int? MaritalStatus { get; set; }
        public string? ContactNumber { get; set; }
        public string? MailId { get; set; }
        public int? MailSubscription { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string? Status { get; set; }
        public DateTime? RegDate { get; set; }
        public int? RegUsr { get; set; }
        public DateTime? UptDate { get; set; }
        public int? UptUsr { get; set; }
    }
}
