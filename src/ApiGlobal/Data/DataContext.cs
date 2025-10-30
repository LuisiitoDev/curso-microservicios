using Microsoft.EntityFrameworkCore;
using ApiGlobal.Models;

namespace ApiGlobal.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Adult> Adults { get; set; }

        public DbSet<Child> Children { get; set; }
    }
}