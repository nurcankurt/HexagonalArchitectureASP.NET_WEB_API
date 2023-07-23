using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Application.DrivenAdapter
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
