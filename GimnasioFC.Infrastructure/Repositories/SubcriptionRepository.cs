using GimnasioFC.Domain.Entities;
using GimnasioFC.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Repositories
{
    internal class SubcriptionRepository : ISubscriptionRepository
    {
        public Task Add(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Subscription GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Subscription subscription)
        {
            throw new NotImplementedException();
        }
    }
}
