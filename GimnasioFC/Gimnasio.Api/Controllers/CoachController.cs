using GimnasioFC.Application.Dtos.DtoCoach;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoachController(ICoachServices _repo) : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadCoachDto>>> GetAllCoaches()
        {
            var coaches = await _repo.GetAllCoach();
            return Ok(coaches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadCoachDto>> GetCoachById(int id)
        {
            var coach = await _repo.GetCoachById(id);
            if (coach == null)
            {
                return NotFound();
            }
            return Ok(coach);
        }

        [HttpPost]
        public async Task<ActionResult> AddCoach(CreateCoachDto coach)
        {
            await _repo.AddCoach(coach);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCoach(int id, CreateCoachDto coach)
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
