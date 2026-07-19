using ClinicaFC.Domain.Repository;
using ClinicaFC.Infraestructure.Context;
using MediCore.Core.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Infraestructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ClinicaFCDbContext _db;
        protected readonly DbSet<T> _table;

        public GenericRepository(ClinicaFCDbContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _table
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _table.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _table.FindAsync(id);

            if (entity != null)
            {
                _table.Remove(entity);
                await _db.SaveChangesAsync();
            }
        }
    }
}
