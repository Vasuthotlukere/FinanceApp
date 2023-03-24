using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.AppDbContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppUsers> Users { get; set; }
        
    }
}