using GimnasioFC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Domain.Repository
{
    public interface ISubscriptionRepository
    {
        public Task<IEnumerable<Subscription>> GetAll();

        public Subscription GetById(int id);

        public Task Add(Subscription subscription);

        public Task Update(Subscription subscription);

        public Task Delete(int id);
    }
}
