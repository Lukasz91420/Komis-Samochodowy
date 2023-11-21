using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Komis.Models;

namespace Komis.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Komis.Models.Samochodzik>? Samochodzik { get; set; }
        public DbSet<Komis.Models.RodzajPaliwa>? RodzajPaliwa { get; set; }
        public DbSet<Komis.Models.RodzajNadwozia>? RodzajNadwozia { get; set; }
        public DbSet<Komis.Models.Model>? Model { get; set; }
        public DbSet<Komis.Models.Marka>? Marka { get; set; }
    }
}