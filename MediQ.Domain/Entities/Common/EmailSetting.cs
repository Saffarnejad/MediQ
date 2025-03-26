﻿namespace MediQ.Domain.Entities.Common
{
	public class EmailSetting : BaseEntity
	{
		public string From { get; set; }

		public string Password { get; set; }

		public string SMTP { get; set; }

		public bool EnableSSL { get; set; }

		public string DisplayName { get; set; }

		public int Port { get; set; }

		public bool IsDefault { get; set; }
	}
}
