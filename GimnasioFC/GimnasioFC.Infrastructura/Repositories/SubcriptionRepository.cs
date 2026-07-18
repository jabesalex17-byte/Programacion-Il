using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Domain.Entities;
using GimnasioFC.Infrastructura.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Repositories
{
    public class SubcriptionRepository :    ISubscriptionRepository
    {
        private readonly GimnasioDbContext _db;

        public SubcriptionRepository(GimnasioDbContext db)
        {
            _db = db;
        }
        public async Task Add(Subscription subscription)
        {
            var nSubscription = new SubscriptionModel
            {
                MemberId = subscription.MemberId,
                MembershipId = subscription.MembershipId,
                FechaInicio = subscription.FechaInicio,
                FechaFin = subscription.FechaFin,
                Activa = subscription.Activa,
                Id = subscription.Id,
                
            };
            await _db.Subscriptions.AddAsync(nSubscription);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var subscription = await _db.Subscriptions.FindAsync(id);
            if (subscription != null)
            {
                _db.Subscriptions.Remove(subscription);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Subscription>> GetAll()
        {
            var subscriptions = await _db.Subscriptions.AsNoTracking().ToListAsync();
            return subscriptions.Select(s => new Subscription
            {
                Activa = s.Activa,
                FechaFin = s.FechaFin,
                FechaInicio = s.FechaInicio,
                MemberId = s.MemberId,
                MembershipId = s.MembershipId,
                Id = s.Id
            });
        }

        public async Task<Subscription> GetById(int id)
        {
            var subscription = await _db.Subscriptions.AsNoTracking().FirstAsync(c => c.MembershipId == id);
            if (subscription == null)
            {
                return null;
            }
            return new Subscription
            {
                Activa = subscription.Activa,
                FechaFin = subscription.FechaFin,
                FechaInicio = subscription.FechaInicio,
                MemberId = subscription.MemberId,
                MembershipId = subscription.MembershipId,
                Id = subscription.Id
            };
        }

        public async Task Update(int id,Subscription subscription)
        {
            var existingSubscription = await _db.Subscriptions.FindAsync(id);
            if (existingSubscription != null)
            {
                existingSubscription.MemberId = subscription.MemberId;
                existingSubscription.MembershipId = subscription.MembershipId;
                existingSubscription.FechaInicio = subscription.FechaInicio;
                existingSubscription.FechaFin = subscription.FechaFin;
                existingSubscription.Activa = subscription.Activa;
                

                await _db.SaveChangesAsync();
            }
        }
    }
}
