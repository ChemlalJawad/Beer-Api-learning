using Genesis.Core.Domaine;
using Microsoft.EntityFrameworkCore;
namespace Genesis.Data
{
    public class GenesisContext : DbContext
    {
        public GenesisContext(DbContextOptions<GenesisContext> options) : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
    }
}
