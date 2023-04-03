using Employees.API.Data;
using Employees.API.Models;
using Employees.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employees.API.Controllers
{
    [ApiController]
    [Route("api/Employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public  async Task< IActionResult> GetAllEmployees()
        {
           var employees =await _employeeService.GetAllEmployees();

            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
           var employees = await _employeeService.AddEmployee(employee);

            return Ok(employee);
        }
    }
}
