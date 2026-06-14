using GimnasioFC.Data;
using GimnasioFC.Models;
using GimnasioFC.DTOs;
using Microsoft.AspNetCore.Mvc; 

namespace GimnasioFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CoachDTO>> GetCoaches()
        {
            var coaches = ListProgram.Coaches.AsReadOnly();

            return Ok(coaches.Select(x => new CoachDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                HireDate = x.HireDate,
                Salary = x.Salary,
                IsActive = x.IsActive
            }));
        }

        [HttpPost]
        public ActionResult AddCoach(CoachDTO coach)
        {
            if (coach is null)
            {
                return NotFound();
            }

            coach.Id = ListProgram.cId++;

            var newCoach = new Coach
            {
                Id = coach.Id,
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Age = coach.Age,
                Email = coach.Email,
                PhoneNumber = coach.PhoneNumber,
                HireDate = coach.HireDate,
                Salary = coach.Salary,
                IsActive = coach.IsActive
            };

            ListProgram.Coaches.Add(newCoach);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCoach(int id)
        {
            var coach = ListProgram.Coaches.FirstOrDefault(x => x.Id == id);

            if (coach is null)
            {
                return NotFound();
            }

            ListProgram.Coaches.Remove(coach);

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCoach(int id, CoachDTO newCoach)
        {
            var coach = ListProgram.Coaches.FirstOrDefault(x => x.Id == id);

            if (coach is null)
            {
                return NotFound();
            }

            coach.FirstName = newCoach.FirstName;
            coach.LastName = newCoach.LastName;
            coach.Age = newCoach.Age;
            coach.Email = newCoach.Email;
            coach.PhoneNumber = newCoach.PhoneNumber;
            coach.HireDate = newCoach.HireDate;
            coach.Salary = newCoach.Salary;
            coach.IsActive = newCoach.IsActive;

            return NoContent();
        }
    }
}
