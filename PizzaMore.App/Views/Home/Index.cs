namespace PizzaMore.App.Views.Home
{
    using PizzaMore.App.Helpers;
    using SimpleMVC.Interfaces;
    public class Index : IRenderable
    {
        public string Render()
        {
            string htmlContent = PathReader.Read(Constants.HomePath);
            return htmlContent;
        }
    }
}
