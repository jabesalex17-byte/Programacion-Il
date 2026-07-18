using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Domain.Entities;
using GimnasioFC.Infrastructura.Context;
using Microsoft.EntityFrameworkCore;
namespace GimnasioFC.Infrastructura.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GimnasioDbContext _db;

        public EmployeeRepository(GimnasioDbContext db)
        {
            _db = db;
        }
        public async Task AddEmployee(Employee employee)
        {
            var newEmployee = new EmployeeModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                HireDate = employee.HireDate,
                IsActive = employee.IsActive,
                Age = employee.Age,
                Email = employee.Email,
                id = employee.id,
                PhoneNumber = employee.PhoneNumber,
        
            };
            await _db.Employees.AddAsync(newEmployee);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _db.Employees.FindAsync(id);
            if (employee != null)
            {
                _db.Employees.Remove(employee);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee()
        {
            var employees = await _db.Employees.AsNoTracking().ToListAsync();
            return employees.Select(e => new Employee
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                JobTitle = e.JobTitle,
                Salary = e.Salary,
                HireDate = e.HireDate,
                IsActive = e.IsActive,
                id = e.id,
                Age = e.Age,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber
            });
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _db.Employees.AsNoTracking().FirstOrDefaultAsync(e => e.id == id);
            if (employee == null)
            {
                return null;
            }
            return new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                HireDate = employee.HireDate,
                IsActive = employee.IsActive,
                id = employee.id,
                Age = employee.Age,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber
            };
        }

        public async Task UpdateEmployee(int id,Employee employee)
        {
            var existingEmployee = await _db.Employees.FindAsync(id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.JobTitle = employee.JobTitle;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.HireDate = employee.HireDate;
                existingEmployee.IsActive = employee.IsActive;
                existingEmployee.Age = employee.Age;
                existingEmployee.Email = employee.Email;
                existingEmployee.PhoneNumber = employee.PhoneNumber;

                await _db.SaveChangesAsync();
            }
        }
    }
}
