using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;

namespace WorkReports.Data
{
    public class DatabaseContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public DatabaseContext(DbContextOptions options) : base(options) => _options = options;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        Name = "Sahar",
            //        Family = "Nazari",
            //        Email = "SaharNazari@gmail.com",
            //        Password = "6871814"
            //    },
            //    new User
            //    {
            //        Id = 2,
            //        Name = "Ali",
            //        Family = "Ghasemzad",
            //        Email = "Alighasemzad@gmail.com",
            //        Password = "123456"
            //    }
            //    );

            //builder.Entity<WorkReport>().HasData(
            //    new WorkReport
            //    {
            //        Id = 1,
            //        Description = "User panel",
            //        LastWorkedDate = DateTime.Now,
            //        DailyWorkHour = 8,
            //        MonthlyWorkHour = 180,
            //        TotalWorkHour = 500,
            //        IsAccepted = 1,
            //        UserId = 1
            //    },
            //    new WorkReport
            //    {
            //        Id = 2,
            //        Description = "طراحی سیستم انبار",
            //        LastWorkedDate = DateTime.Now,
            //        DailyWorkHour = 7,
            //        MonthlyWorkHour = 180.53,
            //        TotalWorkHour = 1000.2,
            //        IsAccepted = 0,
            //        UserId = 2
            //    }
            //    );

            //builder.Entity<PersonWork>().HasData(
            //    new PersonWork
            //    {
            //        Id = 1,
            //        Description = "اضاهه کردن بخش X, Y",
            //        StartHour = new TimeSpan(2, 14, 18),
            //        EndHour = new TimeSpan(3, 10, 00),
            //        DoneDate = DateTime.Now,
            //        Opration = "تکمیل سیستم انبار"

            //    }

            //    );

        }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkReport> WorkReports { get; set; }
        public DbSet<PersonWork> PersonWorks { get; set; }
    }

}
