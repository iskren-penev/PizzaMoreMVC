namespace PizzaMore.App.Controllers
{
    using PizzaMore.App.BindingModels;
    using PizzaMore.App.Security;
    using PizzaMore.App.Services;
    using SimpleHttpServer.Models;
    using SimpleMVC.Attributes.Methods;
    using SimpleMVC.Controllers;
    using SimpleMVC.Interfaces;

    public class UserController : Controller
    {
        private SignInManager signInManager;

        public UserController()
        {
            this.signInManager = new SignInManager(Data.Data.Context);
        }

        [HttpGet]
        public IActionResult Index(HttpSession session, HttpResponse response)
        {
            if (!this.signInManager.IsAuthenticated(session))
            {
                Redirect(response, "/home/index");
                return null;
            }

            return this.View();
        }


        [HttpGet]
        public IActionResult Signin()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Signin(SignInBindingModel model, HttpSession session, HttpResponse response)
        {
            UserService service = new UserService(Data.Data.Context);
            service.LoginUser(model, session);
            if (!this.signInManager.IsAuthenticated(session))
            {
                Redirect(response, "/home/index");
                return null;
            }

            Redirect(response, "/user/index");
            return null;
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Signup(SignUpBindingModel model, HttpResponse response)
        {
            UserService service = new UserService(Data.Data.Context);
            service.RegisterUser(model);
            Redirect(response, "/home/index");
            return null;
        }
    }
}
