using GimnasioFC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Interfaces.Repository
{
    public interface ISubscriptionRepository
    {
        public Task<IEnumerable<Subscription>> GetAll();

        public Task Add(Subscription subscription);

        public Task Update(int id, Subscription subscription);

        public Task Delete(int id);
        public Task<Subscription> GetById(int id);  
    }
}
