
using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Domain.Entities;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(IEmployeeRepository _repo) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            var employees = await _repo.GetAllEmployee();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _repo.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee employee)
        {
            await _repo.AddEmployee(employee);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee(int id, Employee employee)
        {
            await _repo.UpdateEmployee(id, employee);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            await _repo.DeleteEmployee(id);
            return Ok();
        }
    }
}
