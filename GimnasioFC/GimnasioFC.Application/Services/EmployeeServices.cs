using GimnasioFC.Application.Dtos.DtoEmployee;
using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Services
{
    public  class EmployeeServices (IEmployeeRepository _repo) : IEmployeeServices
    {
        public async Task AddEmployee(CreateEmployeeDto employee)
        {
            var Nemployee = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                JobTitle = employee.JobTitle
            };
            await _repo.AddEmployee(Nemployee);
        }

        public async Task DeleteEmployee(int id)
        {
           await _repo.DeleteEmployee(id);
        }

        public async Task<IEnumerable<ReadEmployeeDto>> GetAllEmployee()
        {
          var coaches =  await _repo.GetAllEmployee();
            return coaches.Select(c => new ReadEmployeeDto
              {
              FirstName = c.FirstName,
              LastName = c.LastName,
              Age = c.Age,
              Email = c.Email,
              PhoneNumber = c.PhoneNumber
              });
        }

        public async Task<ReadEmployeeDto> GetEmployeeById(int id)
        {
            var employee = await _repo.GetEmployeeById(id);
            if (employee == null)
            {
                return null;
            }
            var Nemployee = new ReadEmployeeDto
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber
            };
            return Nemployee;
        }

        public async Task UpdateEmployee(int id, CreateEmployeeDto employee)
        {
            var Nemployee = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                JobTitle = employee.JobTitle
            };

            await _repo.UpdateEmployee(id, Nemployee);
        }
    }
}
