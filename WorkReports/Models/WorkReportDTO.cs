using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Models
{
    public class WorkReportDTO
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public double DailyWorkHour { get; set; }
        public double MonthlyWorkHour { get; set; }
        public double TotalWorkHour { get; set; }
        [Required]
        public DateTime LastWorkedDate { get; set; }
        public int? IsAccepted { get; set; }
        public UserDTO User{ get; set; }

    }
}
