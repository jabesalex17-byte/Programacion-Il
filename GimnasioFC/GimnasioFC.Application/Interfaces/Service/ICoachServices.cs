using GimnasioFC.Application.Dtos.DtoCoach;
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Service
{
    public interface ICoachServices
    {
        public Task<IEnumerable<ReadCoachDto>> GetAllCoach();

        public Task AddCoach(CreateCoachDto coach);

        public Task UpdateCoach(int id, CreateCoachDto coach);

        public Task DeleteCoach(int id);

        public Task<ReadCoachDto> GetCoachById(int id);
    }
}
