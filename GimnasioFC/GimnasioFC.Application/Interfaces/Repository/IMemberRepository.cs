using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Repository
{
    public interface IMemberRepository
    {
        public Task<IEnumerable<Member>> GetAll();

        public Task Add(Member member);

        public Task Update(int id, Member member);

        public Task Delete(int id);
        public Task<Member> GetById(int id);
    }
}
