using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkReports.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public int Userid { get; set; } 
    }
}
