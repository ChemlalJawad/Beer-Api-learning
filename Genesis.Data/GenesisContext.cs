using Genesis.Core.Domaine;
using Microsoft.EntityFrameworkCore;
namespace Genesis.Data
{
    public class GenesisContext : DbContext
    {
        public GenesisContext(DbContextOptions<GenesisContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntreprise>()
                .HasKey(pt => new { pt.ContactId, pt.EntrepriseId });

            modelBuilder.Entity<ContactEntreprise>()
                .HasOne(pt => pt.Contact)
                .WithMany(p => p.Entreprises)
                .HasForeignKey(pt => pt.ContactId);

            modelBuilder.Entity<ContactEntreprise>()
                .HasOne(pt => pt.Entreprise)
                .WithMany(t => t.Contacts)
                .HasForeignKey(pt => pt.EntrepriseId);
        }
        public DbSet<ContactEntreprise> ContactsEntreprises { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
    }
}
