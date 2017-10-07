using Microsoft.EntityFrameworkCore;
using PizzaAppCore.ViewModels;

namespace PizzaAppCore.Models
{
    public class PizzaAppContext : DbContext
    {
        public DbSet<CustomerModel> Customer { get; set; }
        public DbSet<PizzaModel> Pizza { get; set; }
        public DbSet<ExtraIngredientsModel> ExtraIngredients { get; set; }
        public DbSet<OrderModel> Order { get; set; }

        public PizzaAppContext(DbContextOptions<PizzaAppContext> options)
            :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerModel>().ToTable("Customer");
            modelBuilder.Entity<PizzaModel>().ToTable("Pizza");
            modelBuilder.Entity<ExtraIngredientsModel>().ToTable("ExtraIngredients");
            modelBuilder.Entity<OrderModel>().ToTable("Order");
        }
    }
}
