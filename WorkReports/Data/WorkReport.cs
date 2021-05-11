using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Data
{
    public class WorkReport
    {
        public int Id{ get; set; }
        public string Description { get; set; }
        public double DailyWorkHour { get; set; }
        public double MonthlyWorkHour { get; set; }
        public double TotalWorkHour { get; set; }
        public DateTime LastWorkedDate { get; set; }
        public int? IsAccepted { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User{ get; set; }
    



    }
}
