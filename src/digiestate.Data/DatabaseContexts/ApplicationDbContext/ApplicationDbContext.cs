using digiestate.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace digiestate.Data.DatabaseContexts.ApplicationContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Property> Properties { get; set;}
        public DbSet<Contact> Contacts { get; set;}
    }
}