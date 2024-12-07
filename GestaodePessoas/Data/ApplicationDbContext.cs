using GestaodePessoas.Models;
using Microsoft.EntityFrameworkCore;


namespace GestaodePessoas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) :base(option)
        {
            
        }

        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Person> People { get; set; }
        
    }
}
