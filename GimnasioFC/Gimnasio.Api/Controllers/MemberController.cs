using GimnasioFC.Domain.Repository;
using GimnasioFC.Infrastructura.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gimnasio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberRepository _repo;

        public MemberController(IMemberRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Member>>> GetAllMember()
        {
            var Members = await _repo.GetAll();
            return Ok(Members);
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
