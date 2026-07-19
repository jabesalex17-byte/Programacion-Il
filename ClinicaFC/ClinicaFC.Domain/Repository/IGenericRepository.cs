using MediCore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Domain.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<T?> GetById(int id);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
