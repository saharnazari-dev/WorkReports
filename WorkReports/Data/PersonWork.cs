using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Data
{
    public class PersonWork
    {
        public int Id{ get; set; }
        public string Description{ get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour{ get; set; }
        public DateTime DoneDate{ get; set; }
        public string Opration { get; set; }
    }
}
