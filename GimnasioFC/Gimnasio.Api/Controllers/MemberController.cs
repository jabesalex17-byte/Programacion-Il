
using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController(IMemberRepository _repo) : ControllerBase
    {

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Member>>> GetAllMember()
        {
            var Members = await _repo.GetAll();
            return Ok(Members);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMemberById(int id)
        {
            var member = await _repo.GetById(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }   

        [HttpPost]
        public async Task<ActionResult> AddMember(Member member)
        {
            await _repo.Add(member);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMember(int id, Member member)
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
