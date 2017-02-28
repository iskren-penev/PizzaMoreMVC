namespace PizzaMore.App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaMore.App.Data.PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PizzaMore.App.Data.PizzaContext";
        }

        protected override void Seed(PizzaMore.App.Data.PizzaContext context)
        {
            
        }
    }
}
