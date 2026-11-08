using Microsoft.EntityFrameworkCore;
using Lab03.Models;

namespace Lab03.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rsvp> Rsvps { get; set; }
    }
}
