using Microsoft.EntityFrameworkCore;
using OrchestraSystem.Models;
using System.Diagnostics.Metrics;

namespace OrchestraSystem.Data
{
    public class OrchestraContext : DbContext
    {
        public OrchestraContext(DbContextOptions<OrchestraContext> options) : base(options) {

        }

        public DbSet<MusicoModel> Musico { get; set; }
        public DbSet<OrchestraModel> Orchestra { get; set; }
        public DbSet<SymphonyModel> Symphony { get; set; }
        public DbSet<InstrumentModel> Instrument { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicoModel>()
                .HasMany(m => m.Instruments) // Um músico possui muitos instrumentos
                .WithMany(i => i.Musicians)  // Um instrumento é tocado por muitos músicos
                .UsingEntity(j => j.ToTable("MusicoInstrument")); // Nome da tabela de junção
        }

       

    }
}
