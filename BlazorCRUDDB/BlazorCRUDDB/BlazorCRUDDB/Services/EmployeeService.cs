using BlazorCRUDDB.DAL;
using BlazorCRUDDB.Interfaces;
using BlazorCRUDDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDB.Services
{
    public class EmployeeService : IEmployeeInterface
    {
        private readonly MyAppDbContext _context;

        public EmployeeService(MyAppDbContext context)
        {
            _context = context;
        }

        public Task<bool> AddUpdateAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public Task<Employee> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
