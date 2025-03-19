using BlazorCRUDDB.Models;

namespace BlazorCRUDDB.Interfaces
{
    public interface IEmployeeInterface
    {
        Task<bool> AddUpdateAsync(Employee employee);
        Task<bool> DeleteAsync(Guid id);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(Guid id);
    }
}
