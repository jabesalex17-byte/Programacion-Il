
using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Infrastructura.Context;
using GimnasioFC.Infrastructura.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly GimnasioDbContext _db;

        public MemberRepository(GimnasioDbContext db)
        {
            _db = db;
        }

        public async Task Add(Member member)
        {
            var nMember = new MemberModel
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                Active = member.Active,
                RegistrationDate = member.RegistrationDate,
                id = member.id,
                
            };
            await _db.Members.AddAsync(nMember);
            await _db.SaveChangesAsync();
            return;
        }

        public async Task Delete(int id)
        {
            var member =  await _db.Members.FindAsync(id);
            if (member != null)
            {
                _db.Members.Remove(member);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<Member>> GetAll()
        {
            var members = await _db.Members.AsNoTracking().ToListAsync();
            return members.Select(m => new Member
            {
                FirstName = m.FirstName,
                LastName = m.LastName,
                Age = m.Age,
                Email = m.Email,
                PhoneNumber = m.PhoneNumber,
                Active = m.Active,
               RegistrationDate = m.RegistrationDate,
               id = m.id


            })
            ;

        }

        public async Task<Member> GetById(int id)
        {
            var member = await _db.Members.AsNoTracking().FirstOrDefaultAsync(m => m.id == id);
            if (member == null) 
            {
                return null;
            }
            return new Member
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                Age = member.Age,
                Email = member.Email,
                PhoneNumber = member.PhoneNumber,
                Active = member.Active,
                RegistrationDate = member.RegistrationDate,
                id = member.id
            };
        }

        public async Task Update(int id,Member member)
        {
            var nMember = await _db.Members.AsNoTracking().FirstAsync(c => c.id == id);
            if (nMember != null)
            {
                nMember.FirstName = member.FirstName;
                nMember.LastName = member.LastName;
                nMember.Age = member.Age;
                nMember.Email = member.Email;
                nMember.PhoneNumber = member.PhoneNumber;
                nMember.Active = member.Active;
                nMember.RegistrationDate = member.RegistrationDate;

                await _db.SaveChangesAsync();
            }
        }
    }
}
