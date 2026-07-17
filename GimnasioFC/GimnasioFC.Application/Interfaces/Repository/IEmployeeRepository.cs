using GimnasioFC.Domain.Entities;

namespace GimnasioFC.Application.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAllEmployee();

        public Task AddEmployee(Employee employee);

        public Task UpdateEmployee(int id, Employee employee);

        public Task DeleteEmployee(int id);
        public Task<Employee> GetEmployeeById(int id);
    }
}