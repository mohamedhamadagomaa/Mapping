using MappingView.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MappingView.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderWithDetailsView> OrderWithDetailsViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products", schema: "Inventory").HasKey(x => x.Id);
            modelBuilder.Entity<Order>().ToTable("Orders", schema: "Sales").HasKey(x => x.Id);
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails", schema: "Sales").HasKey(x => x.Id);
            modelBuilder.Entity<OrderWithDetailsView>().ToView("OrderWithDetailsView", schema: "dbo").HasNoKey();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

            var constr = configuration.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);

        }
    }
}
