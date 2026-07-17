using GimnasioFC.Application.Dtos.DtoMember;
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Service
{
    public interface IMemberServices
    {
        public Task<IEnumerable<ReadMemberDto>> GetAll();

        public Task Add(CreateMemberDto member);

        public Task Update(int id, CreateMemberDto member);

        public Task Delete(int id);
        public Task<ReadMemberDto> GetById(int id);
    }
}
