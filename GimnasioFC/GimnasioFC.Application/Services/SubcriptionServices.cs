using GimnasioFC.Application.Dtos.DtoSubcription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Domain.Entities;

namespace GimnasioFC.Application.Services
{
    public class SubcriptionServices(ISubscriptionRepository _repo) : ISubscriptionServices
    {
        public async Task Add(CreateSubcriptionDto subscription)
        {
            var Nsubscription = new Subscription
            {
                MembershipId = subscription.MembershipId,
                FechaInicio = subscription.FechaInicio,
                FechaFin = subscription.FechaFin,
                Activa = true
            };
            await _repo.Add(Nsubscription);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<IEnumerable<ReadSubcriptionDto>> GetAll()
        {
            var subscriptions = await _repo.GetAll();
            return subscriptions.Select(s => new ReadSubcriptionDto
            {
                FechaInicio = s.FechaInicio,
                FechaFin = s.FechaFin,
                Activa = s.Activa
            });
        }

        public async Task Update(int id, CreateSubcriptionDto subscription)
        {
            var Nsubscription = new Subscription
            {
                MembershipId = subscription.MembershipId,
                FechaInicio = subscription.FechaInicio,
                FechaFin = subscription.FechaFin,
                Activa = true
            };
            await _repo.Update(id, Nsubscription);
        }

        public async Task<ReadSubcriptionDto> GetById(int id)
        {
           var subscription = await _repo.GetById(id);
            if (subscription == null)
            {
                return null;
            }
            var Nsubscription = new ReadSubcriptionDto
            {
                FechaInicio = subscription.FechaInicio,
                FechaFin = subscription.FechaFin,
                Activa = subscription.Activa
            };
            return Nsubscription;
        }
    }
}
