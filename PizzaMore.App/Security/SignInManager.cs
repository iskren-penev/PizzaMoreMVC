namespace PizzaMore.App.Security
{
    using System.Collections.Generic;
    using PizzaMore.App.Data;
    using SimpleHttpServer.Models;
    using System.Linq;

    public class SignInManager
    {
        private PizzaContext context;

        public SignInManager(PizzaContext context)
        {
            this.context = context;
        }

        public bool IsAuthenticated(HttpSession session)
        {
            return this.context.Sessions.Any(s => s.Id == session.Id && s.IsActive);
            
        }
    }
}
