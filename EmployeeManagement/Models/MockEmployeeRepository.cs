using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
        public List<Employee> GetEmployees()
        {
            return _employeeList.ToList();
        }
        public Employee NewEmployee(int Id, string name, string email, string dept)
        {
            Employee emp = new Employee() { Id = 1, Name = "Sue Johnson", Email = "sjohnson@company.com", Department = "Sales" };
            _employeeList.Add(emp);
            return emp;
        }
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Sue Johnson", Email = "sjohnson@company.com", Department = "Sales" },
                new Employee() { Id = 2, Name = "Mary Riggleman", Email = "mr22@company.com", Department = "Sales" },
                new Employee() { Id = 3, Name = "Kathy Piper", Email = "kpips@company.com", Department = "Management" },
                new Employee() { Id = 4, Name = "Mathew Elderman", Email = "melderman@company.com", Department = "IT" }
            };

        }
    }
}
