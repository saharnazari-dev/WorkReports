using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WorkReports.Data;

namespace WorkReports.Configuration
{
    public class UserFluentConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Family).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Family).HasColumnName("LastName");
            builder.Property(c => c.Name).HasColumnName("FirstName");
        }
    }
}
