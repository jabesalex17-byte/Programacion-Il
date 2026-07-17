using GimnasioFC.Application.Dtos.DtoMember;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController(IMemberServices _repo) : ControllerBase
    {

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ReadMemberDto>>> GetAllMember()
        {
            var Members = await _repo.GetAll();
            return Ok(Members);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadMemberDto>> GetMemberById(int id)
        {
            var member = await _repo.GetById(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }   

        [HttpPost]
        public async Task<ActionResult> AddMember(CreateMemberDto member)
        {
            await _repo.Add(member);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMember(int id, CreateMemberDto member)
        {
            await _repo.Update(id, member);
            if (member == null)
            {
                return NotFound();
            }
            return Ok();
        }   

        [HttpDelete]

        public async Task<ActionResult> DeleteMember(int id)
        {
            await _repo.Delete(id);
            return Ok();
        }


    }
}
