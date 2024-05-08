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
                .HasKey(s => s.shipmentID);

            modelBuilder.Entity<Unit>()
                .HasKey(unit => unit.UnitID);

            modelBuilder.Entity<UserAccount>()
            .HasKey(acc => acc.UserID);

            modelBuilder.Entity<UserInformation>()
                .HasKey(User => User.UserID);            
        
        }
    }
}
