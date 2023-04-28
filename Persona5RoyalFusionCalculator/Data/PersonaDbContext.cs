using Microsoft.EntityFrameworkCore;
using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Data
{
    public class PersonaDbContext : DbContext
    {
        public PersonaDbContext(DbContextOptions<PersonaDbContext> options)
: base(options)
        {

        }

        public DbSet<FusionModel> Fusions { get; set; }
        public DbSet<PersonaModel> Personas { get; set; }
    }
}
