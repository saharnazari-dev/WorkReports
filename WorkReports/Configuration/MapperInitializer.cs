using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkReports.Data;
using WorkReports.Models;

namespace WorkReports.Configuration
{
    public class MapperInitializer:Profile
    {
        public MapperInitializer()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<WorkReport, WorkReportDTO>().ReverseMap();
            CreateMap<PersonWork, PersonWorkDTO>().ReverseMap();

        }

    }
}
