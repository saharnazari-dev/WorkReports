using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WorkReports.Data;
using WorkReports.IRepository;
using WorkReports.Models;
using WorkReports.Repository;

namespace WorkReports.Controllers
{
    public class WorkReportController : Controller
    {
        private readonly ILogger<WorkReportController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkReportController(ILogger<WorkReportController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public IActionResult JobDone()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> GetPersonWork(PersonWorkDTO Model)
        {
            var Result = await _unitOfWork.personWork.GetAll();
            return View(Result);
        }
        public async Task<IActionResult> GetWorkReport(WorkReportDTO Model)
        {
            var Result = await _unitOfWork.workReports.GetAll();
            return View(Result);

            //var workReports = await _unitOfWork.workReports.GetAll();
            //var results = _mapper.Map<List<WorkReportDTO>>(workReports);
            //return Ok(results);
        }

        public async Task<IActionResult> GetUser(/*UserDTO Model*/)
        {
            //IList<User> Result = await _unitOfWork.users.GetAll();
            //return Json(Result);

            var users = await _unitOfWork.users.GetAll();
            var results = _mapper.Map<List<UserDTO>>(users);
            return Ok(results);

        }

        [HttpPost]
        public async Task<IActionResult> InsertReport1(PersonWorkDTO Model)
        {
            var personWorks = _mapper.Map<PersonWork>(Model);
            await _unitOfWork.personWork.Insert(personWorks);
            await _unitOfWork.Save();
            return RedirectToAction("JobDone", "WorkReport");
        }

        [HttpPost]
        public async Task<IActionResult> InsertReport(PersonWorkDTO Model)
        {
            var personWorks = _mapper.Map<PersonWork>(Model);
            await _unitOfWork.personWork.Insert(personWorks);
            await _unitOfWork.Save();
            return Json(personWorks.Id);

        }


    }
}
