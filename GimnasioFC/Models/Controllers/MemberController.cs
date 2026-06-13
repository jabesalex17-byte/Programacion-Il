using GimnasioFC.Data;
using GimnasioFC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GimnasioFC.DTOs;
namespace GimnasioFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

         
        [HttpGet]
        public ActionResult<IEnumerable<MemberDTOs>> GetMembers()
        {
            var members = ListProgram.Members.AsReadOnly();
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
        public ActionResult AddMember(MemberDTOs member)
        {
            if(member is null)
            {
                return NotFound();
            }
            member.Id = ListProgram.Id++;

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
            ListProgram.Members.Add(newMember);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMember(int id)
        {

            var member = ListProgram.Members.FirstOrDefault(m => m.Id == id);
            if (member is null)
            {
                return NotFound();
            }

            ListProgram.Members.Remove(member);

            return NoContent();

        }

        [HttpPut("{id}")]

        public ActionResult UpdateMember(int id, MemberDTOs newMember)
        {
            var member = ListProgram.Members.FirstOrDefault(m => m.Id == id);
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

            return NoContent();


        }
    }
}
