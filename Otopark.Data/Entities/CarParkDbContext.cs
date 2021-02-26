using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Otopark.Data.Entities
{
    public class CarParkDbContext : DbContext
    {
        public CarParkDbContext() : base("name=CarParkDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarParkingSpace> CarParkingSpaces { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
