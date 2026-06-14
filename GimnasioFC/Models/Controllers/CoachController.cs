using GimnasioFC.Data;
using GimnasioFC.DTOs;
using GimnasioFC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GimnasioFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly DbContextGimnasioFC _db;

        public CoachController(DbContextGimnasioFC db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoachDTO>>> GetCoaches()
        {
            var coaches = await _db.Coaches
                .AsNoTracking()
                .ToListAsync();

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
        public async Task<ActionResult> AddCoach(CoachDTO coach)
        {
            if (coach is null)
            {
                return BadRequest();
            }

            var newCoach = new Coach
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Age = coach.Age,
                Email = coach.Email,
                PhoneNumber = coach.PhoneNumber,
                HireDate = coach.HireDate,
                Salary = coach.Salary,
                IsActive = coach.IsActive
            };

            await _db.Coaches.AddAsync(newCoach);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCoach(int id)
        {
            var coach = await _db.Coaches.FindAsync(id);

            if (coach is null)
            {
                return NotFound();
            }

            _db.Coaches.Remove(coach);

            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCoach(int id, CoachDTO newCoach)
        {
            var coach = await _db.Coaches.FindAsync(id);

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

            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}