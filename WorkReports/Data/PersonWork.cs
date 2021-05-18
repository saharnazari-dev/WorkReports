using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Data
{
    public class PersonWork
    {
        public int Id { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "ساعت شروع")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime StartHour { get; set; }

        [Display(Name ="ساعت پایان")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime EndHour{ get; set; }

        [Display(Name = "تاریخ انجام")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DoneDate{ get; set; }

        [Display(Name ="عنوان")]
        public string Title { get; set; }
    }
}
