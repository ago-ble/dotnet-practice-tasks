using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Person> Persons { get; set;}
        
        public DbSet<Animal> Animals { get; set;}
    }
}
