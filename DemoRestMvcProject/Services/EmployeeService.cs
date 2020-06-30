using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoRestMvcProject.Domain.Models;
using DemoRestMvcProject.Domain.Repositories;
using DemoRestMvcProject.Domain.Services;

namespace DemoRestMvcProject.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService (EmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employeeRepository.GetEmployeeById(Id);
        }
    }
}