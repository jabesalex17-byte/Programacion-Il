using GimnasioFC.Application.Dtos.DtoMember;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Services
{
    public class MemberServices(IMemberRepository _repo) : IMemberServices
    {
        public async Task Add(CreateMemberDto member)
        {
            var Nmember = new Member
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                RegistrationDate = member.RegistrationDate
            };
            await _repo.Add(Nmember);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<IEnumerable<ReadMemberDto>> GetAll()
        {
            var members =await _repo.GetAll();
            return members.Select(m => new ReadMemberDto
            {
                FirstName = m.FirstName,
                LastName = m.LastName,
                Age = m.Age,
                Email = m.Email,
                PhoneNumber = m.PhoneNumber
            });
        }

        public async Task<ReadMemberDto> GetById(int id)
        {
            var member = await _repo.GetById(id);
            if (member == null)
            {
                return null;
            }
            var Nmember = new ReadMemberDto
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber
            };
            return Nmember;
        }

        public async Task Update(int id, CreateMemberDto member)
        {
            var Nmember = new Member
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                RegistrationDate = member.RegistrationDate
            };

           await _repo.Add(Nmember);
        }
    }
}
