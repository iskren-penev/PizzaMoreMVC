namespace PizzaMore.App.Helpers
{
    using System.IO;

    public static class PathReader
    {
        public static string Read(string path)
        {
            string content = File.ReadAllText(path);

            return content;
        }

        public static byte[] ReadContent(string path)
        {
            byte[] content = File.ReadAllBytes(path);

            return content;
        }
    }
}
