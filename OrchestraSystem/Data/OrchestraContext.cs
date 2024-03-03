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

    }
}
