using GimnasioFC.Domain.Repository;
 
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Repositories
{
    public class CoachRepository  : ICoachRepository
    {
        public Task AddCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCoach(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Coach>> GetAllCoach()
        {
            throw new NotImplementedException();
        }

        public Task<Coach?> GetCoachById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCoach(Coach coach)
        {
            throw new NotImplementedException();
        }
    }
}
