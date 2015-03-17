using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Relational;
using Microsoft.Data.Entity.SqlServer;
using Microsoft.Data.Entity.Storage;

namespace DockerDemo1.web.Models
{
    public class CallTreeDbContext : DbContext
    {
		public DbSet<NotificationLogs> NotificationLogs { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<NotificationLogs>()
				.Key(x => x.NotificationLogId);
		}
	}
}