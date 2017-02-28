namespace PizzaMore.App.Services
{
    using System.Linq;
    using PizzaMore.App.BindingModels;
    using PizzaMore.App.Data;
    using PizzaMore.App.Models;
    using SimpleHttpServer.Models;

    public class UserService : Service
    {
        public UserService(PizzaContext context) : base(context)
        {
        }

        public void RegisterUser(SignUpBindingModel model)
        {
            User user = new User()
            {
                Email = model.Email,
                Password = model.Password
            };

            this.context.Users.Add(user);
            this.context.SaveChanges();
        }

        public void LoginUser(SignInBindingModel model, HttpSession session)
        {
            User user = this.context.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if (user != null)
            {
                Session dbSession = new Session()
                {
                    Id = session.Id,
                    User = user,
                    IsActive = true
                };

                this.context.Sessions.Add(dbSession);
                this.context.SaveChanges();
            }
        }
    }
}
