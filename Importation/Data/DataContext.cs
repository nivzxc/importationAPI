using Importation.Model;
using Microsoft.EntityFrameworkCore;

namespace Importation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UserAccount> UsersAccount { get; set; }
        public DbSet<UserInformation> UsersInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>()
                .HasKey(s => new { s.shipmentid });
            modelBuilder.Entity<Shipment>()
                .HasMany(u => u.Units);


            modelBuilder.Entity<Unit>()
                .HasKey(u => new { u.UnitId });
            modelBuilder.Entity<Unit>()
                .HasOne(s => s.shipmentId);

            modelBuilder.Entity<UserAccount>()
                .HasKey(ua => new { ua.UserID });

            modelBuilder.Entity<UserInformation>()
                .HasKey(ui => new { ui.UserID });
            modelBuilder.Entity<UserInformation>()
                .HasOne(u => u.UserLoginID);                         

        }
    }
}
