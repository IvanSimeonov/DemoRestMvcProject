using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoRestMvcProject.Domain.Models;
using DemoRestMvcProject.Domain.Repositories;
using DemoRestMvcProject.Services;

namespace DemoRestMvcProject.Controllers
{
    public class EmployeeController : ApiController
    {
       
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            EmployeeRepository repo = new EmployeeRepository();
            EmployeeService service = new EmployeeService(repo);
            return service.GetEmployees();
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            EmployeeRepository repo = new EmployeeRepository();
            EmployeeService service = new EmployeeService(repo);
            return service.GetEmployeeById(id);
        }
    }
}
