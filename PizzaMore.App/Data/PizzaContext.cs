namespace PizzaMore.App.Data
{
    using System.Data.Entity;
    using PizzaMore.App.Models;

    public class PizzaContext : DbContext
    {

        public PizzaContext()
            : base("PizzaContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<Session> Sessions { get; set; }
    }
}