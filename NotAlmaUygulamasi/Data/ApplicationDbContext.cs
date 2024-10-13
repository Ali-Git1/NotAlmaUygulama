using Microsoft.EntityFrameworkCore;
using NotAlmaUygulamasi.Models;

namespace NotAlmaUygulamasi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
