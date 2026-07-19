using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Application.Interfaces
{
    public interface IGenericService<TCreateDto, TReadDto>
    {
        Task<IEnumerable<TReadDto>> GetAll();

        Task<TReadDto?> GetById(int id);

        Task Add(TCreateDto entity);

        Task Update(int id, TCreateDto entity);

        Task Delete(int id);
    }
}
