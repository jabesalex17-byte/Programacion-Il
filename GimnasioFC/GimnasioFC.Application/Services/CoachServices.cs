using GimnasioFC.Application.Dtos.DtoCoach;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Infrastructura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Services
{
    public class CoachServices(ICoachRepository _repo) : ICoachServices
    {
        public async Task AddCoach(CreateCoachDto coach)
        {
            var Ncoach = new Coach
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Age = coach.Age,
                Email = coach.Email,
                PhoneNumber = coach.PhoneNumber,
                Specialty = coach.Specialty,

            };
            await _repo.AddCoach(Ncoach);
        }

        public async Task DeleteCoach(int id)
        {
            await _repo.DeleteCoach(id);
        }

        public async Task<IEnumerable<ReadCoachDto>> GetAllCoach()
        {
            var coaches = await _repo.GetAllCoach();
            return coaches.Select(c => new ReadCoachDto
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Age = c.Age,
                Email = c.Email
            });

        }

        public async Task<ReadCoachDto> GetCoachById(int id)
        {
            var coach = await _repo.GetCoachById(id);
            if (coach == null)
            {
                return null;
            }
            var Ncoach = new ReadCoachDto
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Age = coach.Age,
                Email = coach.Email
            };
            return Ncoach;

        }

        public async Task UpdateCoach(int id, CreateCoachDto coach)
        {
            var Ncoach = new Coach
            {
                FirstName = coach.FirstName,
                LastName = coach.LastName,
                Age = coach.Age,
                Email = coach.Email,
                PhoneNumber = coach.PhoneNumber,
                Specialty = coach.Specialty,

            };
            await _repo.UpdateCoach(id, Ncoach);
        }
    }
}
