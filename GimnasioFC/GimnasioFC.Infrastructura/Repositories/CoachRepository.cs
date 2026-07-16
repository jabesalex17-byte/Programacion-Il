using GimnasioFC.Domain.Repository;
using GimnasioFC.Infrastructura.Context;
using GimnasioFC.Infrastructura.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Repositories
{
    public class CoachRepository  : ICoachRepository
    {
        private readonly GimnasioDbContext _db;

        public CoachRepository(GimnasioDbContext db)
        {
            _db = db;
        }
        public async Task AddCoach(Coach coach)
        {
            var Ncoach = new CoachModel
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Specialty = coach.Specialty,
                Active = coach.Active,
                Salary = coach.Salary,
                Email = coach.Email,
                PhoneNumber = coach.PhoneNumber,
                Age = coach.Age,
                id = coach.id
            };
            await _db.Coaches.AddAsync(Ncoach);
            await _db.SaveChangesAsync();
            return;
        }

        public async Task DeleteCoach(int id)
        {
            var coach = await _db.Coaches.FindAsync(id);
            if (coach != null)
            {
                _db.Coaches.Remove(coach);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Coach>> GetAllCoach()
        {
            var coaches = await _db.Coaches.AsNoTracking().ToListAsync();
            return coaches.Select(c => new Coach
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Specialty = c.Specialty,
                Active = c.Active,
                Salary = c.Salary,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber,
                Age = c.Age,
                id = c.id
            });
        }


        public async Task UpdateCoach(int id, Coach coach)
        {
            var existingCoach = await _db.Coaches.FindAsync(id);
            if (existingCoach != null)
            {
                existingCoach.FirstName = coach.FirstName;
                existingCoach.LastName = coach.LastName;
                existingCoach.Specialty = coach.Specialty;
                existingCoach.Active = coach.Active;
                existingCoach.Salary = coach.Salary;
                existingCoach.Email = coach.Email;
                existingCoach.PhoneNumber = coach.PhoneNumber;
                existingCoach.Age = coach.Age;

                await _db.SaveChangesAsync();
            }

        }
    }
}
