using BlazorCRUDDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDDB.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
