using Employees.API.Data;
using Employees.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.API.Services
{
    public class EmployeeService
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeService(EmployeeDbContext employeeDbContext)
        {
            this._employeeDbContext = employeeDbContext;
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _employeeDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            await _employeeDbContext.Employees.AddAsync(employee);
            await _employeeDbContext.SaveChangesAsync();

            return employee;
        }
    }
}
