namespace PizzaMore.App.Services
{
    using PizzaMore.App.Data;

    public abstract class Service
    {
        protected PizzaContext context;

        protected Service(PizzaContext context)
        {
            this.context = context;
        }
    }
}
