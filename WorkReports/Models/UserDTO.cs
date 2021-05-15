using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkReports.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public IList<WorkReportDTO> WorkReports { get; set; }


    }
}
