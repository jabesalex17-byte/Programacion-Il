using GimnasioFC.Domain.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoachController : ControllerBase
    {
        private readonly ICoachRepository _repo;

        public CoachController(ICoachRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coach>>> GetAllCoaches()
        {
            var coaches = await _repo.GetAllCoach();
            return Ok(coaches);
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
