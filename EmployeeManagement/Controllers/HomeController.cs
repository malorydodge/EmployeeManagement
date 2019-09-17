using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //public IActionResult Index()
        public ViewResult Index()
        {
            List<Employee> model= _employeeRepository.GetEmployees();
            return View(model);
        }
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }
        public ViewResult Create()
        {
            Employee model = _employeeRepository.NewEmployee(0,"","","");
            return View(model);
        }
        public ViewResult Delete()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }
        override public ViewResult View()
        {
             Employee model = _employeeRepository.GetEmployee(1);
             return View(model);
        }
        
    }
}