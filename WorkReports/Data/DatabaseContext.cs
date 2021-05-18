using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using WorkReports.Models;

namespace WorkReports.Data
{
    public class DatabaseContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public DatabaseContext(DbContextOptions options) : base(options) => _options = options;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkReport> WorkReports { get; set; }
        public DbSet<PersonWork> PersonWorks { get; set; }
        //public DbSet<WorkReports.Models.WorkReportDTO> WorkReportDTO { get; set; }
    }

}
