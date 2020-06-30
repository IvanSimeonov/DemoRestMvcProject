using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoRestMvcProject.Domain.Models;

namespace DemoRestMvcProject.Domain.Repositories
{
    public class EmployeeRepository
    {

       public List<Employee> employees = new List<Employee>();
        Employee Genata = new Employee
        {
            Id = 1,
            FirstName = "Evgeni",
            LastName = "CTO",
            Age = 12,
            Nationality = Country.Bulgaria
        };

        Employee Vankata = new Employee
        {
            Id = 2,
            FirstName = "Vankata",
            LastName = "CEO",
            Age = 13,
            Nationality = Country.Germany
        };

        Employee Vladi = new Employee
        {
            Id = 3,
            FirstName = "Vladislav",
            LastName = "Scruma",
            Age = 14,
            Nationality = Country.Switzerland
        };

        private void fillDatabase()
        {
            employees.Add(Genata);
            employees.Add(Vankata);
            employees.Add(Vladi);
        }
            

        public List<Employee> GetEmployees()
        {
            fillDatabase();
            return employees;
        }

        public Employee GetEmployeeById(int Id)
        {
            fillDatabase();
            foreach(Employee employee in employees){
                if (employee.Id == Id)
                {
                    return employee;
                }
            }
            return null;
        }
        
    }
}