namespace PizzaMore.App.Views.User
{
    using PizzaMore.App.Helpers;
    using SimpleMVC.Interfaces;
    public class Signin: IRenderable
    {
        public string Render()
        {
            string htmlContent = PathReader.Read(Constants.SignInPath);
            return htmlContent;
        }
    }
}
