using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        List<Employee> GetEmployees();
        Employee NewEmployee(int Id, string name, string email, string dept);
    }
}
