using AutoMapper;
using DemoThreeLayers.Common.Dtos;
using DemoThreeLayers.Common.ViewModels;
using DemoThreeLayers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoThreeLayers.Controllers
{
    public class HomeController : Controller
    {
        readonly IEmployeeService _employeeService;
        readonly IMapper _mapper;

        public HomeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            EmployeeDto temp = _employeeService.GetRehabusInfo(0);
            VmEmployee result = _mapper.Map<VmEmployee>(temp);
            return View(result);
        }
    }
}
