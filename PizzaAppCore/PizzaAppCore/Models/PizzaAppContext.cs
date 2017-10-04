using Microsoft.EntityFrameworkCore;

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

    }
}
