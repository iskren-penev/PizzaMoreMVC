namespace PizzaMore.App.Views.User
{
    using PizzaMore.App.Helpers;
    using SimpleMVC.Interfaces;

    public class Signup : IRenderable
    {
        public string Render()
        {
            string htmlContent = PathReader.Read(Constants.SignUpPath);
            return htmlContent;
        }
    }
}
