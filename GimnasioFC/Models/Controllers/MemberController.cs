using GimnasioFC.Data;
using GimnasioFC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GimnasioFC.DTOs;
using Microsoft.EntityFrameworkCore;
namespace GimnasioFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        private readonly DbContextGimnasioFC _db;

        public MemberController (DbContextGimnasioFC db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTOs>>> GetMembers()
        {
            var members = await _db.Members.AsNoTracking().ToListAsync();
            return Ok(members.Select(x => new MemberDTOs
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                IsActive = x.IsActive,
                EnrollmentDate = x.EnrollmentDate


            }));
        }

        [HttpPost]
        public async Task<ActionResult> AddMember(MemberDTOs member)
        {
            if (member is null)
            {
                return NotFound();
            }
            

            var newMember = new Member
            {
                Id = member.Id,
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                EnrollmentDate = member.EnrollmentDate,
                IsActive = member.IsActive

            };
            await _db.Members.AddAsync(newMember);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMember(int id)
        {

            var member = await _db.Members.FindAsync(id);
            if (member is null)
            {
                return NotFound();
            }

            

             _db.Members.Remove(member);
            await _db.SaveChangesAsync();
            return NoContent();

        }

        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateMember(int id, MemberDTOs newMember)
        {
            var member = await _db.Members.FindAsync(id);
            if (member is null)
            {
                return NotFound();
            }

            member.FirstName = newMember.FirstName;
            member.LastName = newMember.LastName;
            member.Age = newMember.Age;
            member.Email = newMember.Email;
            member.PhoneNumber = newMember.PhoneNumber;
            member.IsActive = newMember.IsActive;
            member.EnrollmentDate = newMember.EnrollmentDate;

            await _db.SaveChangesAsync();
            return NoContent();


        }
    }
}
