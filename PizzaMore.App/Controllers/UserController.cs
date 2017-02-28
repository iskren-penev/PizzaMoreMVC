namespace PizzaMore.App.Controllers
{
    using SimpleMVC.Attributes.Methods;
    using SimpleMVC.Controllers;
    using SimpleMVC.Interfaces;

    public class UserController : Controller
    {
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
