using Practical.Models;
using Practical.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controllers
{
    internal class DoctorEmplyementController
    {
        public DoctorEmployementService _employeeService;

        public DoctorEmplyementController()
        {
            _employeeService = new DoctorEmployementService();
        }

        public void GetFilteredEmployees()
        {
            decimal start = 1000;
            decimal end = 1000;
            foreach (var employee in _employeeService.FilterEmployeeBySalary(start, end))
            {
                string result = $"{employee.name} - {employee.surname} - {employee.salary} - {employee.age}";
                Console.WriteLine(result);
            }
        }

    }
}
