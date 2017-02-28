namespace PizzaMore.App.Views.User
{
    using PizzaMore.App.Helpers;
    using SimpleMVC.Interfaces;
    public class Index : IRenderable
    {
        public string Render()
        {
            string htmlContent = PathReader.Read(Constants.HomeLoggedPath);
            return htmlContent;
        }
    }
}
