using System;
using System.Collections.Generic;

namespace HRnew.Models
{
    public partial class HrNotificationSetting
    {
        public int NotificationId { get; set; }
        public string? NotificationType { get; set; }
        public string? NotificationName { get; set; }
        public string? NotificationDescription { get; set; }
        public int? NotifiedBy { get; set; }
        public DateTime? NotificationDateTime { get; set; }
    }
}
