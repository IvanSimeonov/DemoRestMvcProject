using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoRestMvcProject.Domain.Models;
using DemoRestMvcProject.Domain.Repositories;
using DemoRestMvcProject.Services;
using Swashbuckle.Swagger.Annotations;

namespace DemoRestMvcProject.Controllers
{
    public class EmployeeController : ApiController
    {

        // GET: api/Employee
        [SwaggerOperation("Get all Employees")]
        public IEnumerable<Employee> Get()
        {
            EmployeeRepository repo = new EmployeeRepository();
            EmployeeService service = new EmployeeService(repo);
            return service.GetEmployees();
        }

        // GET: api/Employee/5
        [SwaggerOperation("Get Employee by id")]

        public Employee Get(int id)
        {
            EmployeeRepository repo = new EmployeeRepository();
            EmployeeService service = new EmployeeService(repo);
            return service.GetEmployeeById(id);
        }

        [SwaggerOperation("Test")]
        [Route("test")]
        public String GetTestNullReturn()
        {
            return "test";
        }
    }
}
