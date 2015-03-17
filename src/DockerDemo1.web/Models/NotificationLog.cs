using System;
using Microsoft.Data.Entity;

namespace DockerDemo1.web.Models
{
    public class NotificationLogs
    {
		public int NotificationLogId { get; set; }
		public Guid NotificationInstanceId { get; set; }
		public int PhoneNumberId { get; set; }
		public DateTime CallTime { get; set; }
	}
}