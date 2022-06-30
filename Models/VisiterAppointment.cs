using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class VisiterAppointment
    {
        public int AppointmentId { get; set; }
        public int? VisiterId { get; set; }
        public int? WhomtoMeet { get; set; }
        public DateTime? AppointmentDateTime { get; set; }
        public string? AppointmentSubject { get; set; }
        public string? AppointmentDetails { get; set; }
        public string? AppointmentStatus { get; set; }
        public DateTime? AppointmentRegDateTime { get; set; }
        public int? AppointmentRegBy { get; set; }
        public DateTime? AppointmentUpdtDateTime { get; set; }
        public int? AppointmentUpdtBy { get; set; }
    }
}
