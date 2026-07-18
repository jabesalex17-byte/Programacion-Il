
using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoachController(ICoachRepository _repo) : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coach>>> GetAllCoaches()
        {
            var coaches = await _repo.GetAllCoach();
            return Ok(coaches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coach>> GetCoachById(int id)
        {
            var coach = await _repo.GetCoachById(id);
            if (coach == null)
            {
                return NotFound();
            }
            return Ok(coach);
        }

        [HttpPost]
        public async Task<ActionResult> AddCoach(Coach coach)
        {
            await _repo.AddCoach(coach);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCoach(int id, Coach coach)
        {
            await _repo.UpdateCoach(id,coach);
            if (coach == null)
            {
                return NotFound();
            }   
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCoach(int id)
        {
            await _repo.DeleteCoach(id);
            return Ok();
        }
    }
}
