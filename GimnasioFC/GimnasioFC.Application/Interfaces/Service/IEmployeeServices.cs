using GimnasioFC.Application.Dtos.DtoEmployee;
using GimnasioFC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Application.Interfaces.Service
{
    public interface IEmployeeServices
    {
        public Task<IEnumerable<ReadEmployeeDto>> GetAllEmployee();

        public Task AddEmployee(CreateEmployeeDto employee);

        public Task UpdateEmployee(int id, CreateEmployeeDto employee);

        public Task DeleteEmployee(int id);
        public Task<ReadEmployeeDto> GetEmployeeById(int id);
    }
}
