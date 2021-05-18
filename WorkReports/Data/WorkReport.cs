using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Data
{
    public class WorkReport
    {
        public int Id{ get; set; }


        [Display(Name="توضیحات")]
        public string Description { get; set; }
        
        [Display(Name = "کارکرد روزانه")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public double DailyWorkHour { get; set; }

        [Display(Name = "جمع کارکرد ماهانه ")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public double MonthlyWorkHour { get; set; }


        [Display(Name = "مجموع کل کارکرد ")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public double TotalWorkHour { get; set; }

        [Display(Name = "تازیخ آخرین روز کاری")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime LastWorkedDate { get; set; }

        [Display(Name ="وضعیت")]
        public int? IsAccepted { get; set; }
        
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }


        [Display(Name = "نام و نام خانوادگی")]
        public User User{ get; set; }
    



    }
}
