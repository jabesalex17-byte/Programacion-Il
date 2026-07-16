using GimnasioFC.Domain.Entities;
using GimnasioFC.Domain.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            var employees = await _repo.GetAllEmployee();
            return Ok(employees);
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
