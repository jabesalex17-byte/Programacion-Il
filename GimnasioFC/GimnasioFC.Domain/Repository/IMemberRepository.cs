using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Domain.Repository
{
    public interface IMemberRepository
    {
        public Task<IEnumerable<Member>> GetAll();

        public Member GetById(int id);

        public Task Add(Member member);

        public Task Update(Member member);

        public Task Delete(int id);
    }
}
