namespace PizzaMore.App.Views.Home
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
