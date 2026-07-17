using GimnasioFC.Application.Dtos.DtoSubcription;
using GimnasioFC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Service
{
    public interface ISubscriptionServices
    {
        public Task<IEnumerable<ReadSubcriptionDto>> GetAll();

        public Task Add(CreateSubcriptionDto subscription);

        public Task Update(int id, CreateSubcriptionDto subscription);

        public Task Delete(int id);
        public Task<ReadSubcriptionDto> GetById(int id);
    }
}
