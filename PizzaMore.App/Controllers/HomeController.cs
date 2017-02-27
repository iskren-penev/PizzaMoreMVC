namespace PizzaMore.App.Controllers
{
    using SimpleMVC.Attributes.Methods;
    using SimpleMVC.Controllers;
    using SimpleMVC.Interfaces;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Signin()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return this.View();
        }

    }
}
