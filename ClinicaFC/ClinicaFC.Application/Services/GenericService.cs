using ClinicaFC.Application.Interfaces;
using ClinicaFC.Domain.Repository;
using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Application.Services
{
    public abstract class GenericService<TEntity, TCreateDto, TReadDto>
        : IGenericService<TCreateDto, TReadDto>
        where TEntity : BaseEntity, new()
    {
        protected readonly IGenericRepository<TEntity> _repository;

        protected GenericService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        protected abstract TEntity ToEntity(TCreateDto dto);

        protected abstract TReadDto ToReadDto(TEntity entity);

        public virtual async Task<IEnumerable<TReadDto>> GetAll()
        {
            var entities = await _repository.GetAll();

            return entities.Select(ToReadDto);
        }

        public virtual async Task<TReadDto?> GetById(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
                return default;

            return ToReadDto(entity);
        }

        public virtual async Task Add(TCreateDto dto)
        {
            await _repository.Add(ToEntity(dto));
        }

        public virtual async Task Update(int id, TCreateDto dto)
        {
            var entity = ToEntity(dto);
            entity.Id = id;

            await _repository.Update(entity);
        }

        public virtual async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
