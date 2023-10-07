using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Services
{
    internal class DoctorEmployementService
    {
        public DoctorEmployementModel[] FilterEmployeeBySalary(decimal startSalary, decimal endSalary)
        {
            DoctorEmployementModel[] employees = GetAll();

            DoctorEmployementModel[] fileteredemployees = employees.Where(m => m.salary > startSalary && m.salary < endSalary).ToArray();

            return fileteredemployees;
        }

        private DoctorEmployementModel[] GetAll()
        {
            return new DoctorEmployementModel[]
            {
                new DoctorEmployementModel
                {
                    id = 1,
                    name = "Person A",
                    surname = "Surname A",
                    age = 30,
                    salary = 2000
                },

                new DoctorEmployementModel
                {
                    id = 1,
                    name = "Person B",
                    surname = "Surname B",
                    age = 25,
                    salary = 1500
                },

                new DoctorEmployementModel
                {
                    id = 1,
                    name = "Person C",
                    surname = "Surname C",
                    age = 18,
                    salary = 300
                }
            };

        }
    }

}
