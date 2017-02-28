namespace PizzaMore.App.Helpers
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
            List<string> sessionIds = this.context.Sessions.Select(s => s.Id).ToList();
            if (sessionIds.Contains(session.Id))
            {
                return true;
            }

            return false;
        }
    }
}
