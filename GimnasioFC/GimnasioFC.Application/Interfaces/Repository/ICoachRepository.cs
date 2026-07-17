using GimnasioFC.Application.Dtos.DtoCoach;
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Repository
{
    public interface ICoachRepository
    {
        public Task<IEnumerable<Coach>> GetAllCoach();

        public Task AddCoach(Coach coach);

        public Task UpdateCoach(int id,Coach coach);

        public Task DeleteCoach(int id);
        public Task<Coach> GetCoachById(int id);
    }
}
