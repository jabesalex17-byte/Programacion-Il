using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GimnasioFC.Domain.Entities;
using GimnasioFC.Domain.Repository;
namespace GimnasioFC.Infrastructura.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public Task AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
