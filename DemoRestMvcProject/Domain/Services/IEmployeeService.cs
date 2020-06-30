using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRestMvcProject.Domain.Models;

namespace DemoRestMvcProject.Domain.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees ();
        Employee GetEmployeeById(int Id);
    }
}
