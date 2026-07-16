using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Domain.Repository
{
    public interface ICoachRepository
    {
        public Task<IEnumerable<Coach>> GetAllCoach();

        public Task<Coach?> GetCoachById(int id);

        public Task AddCoach(Coach coach);

        public Task UpdateCoach(Coach coach);

        public Task DeleteCoach(int id);
    }
}
