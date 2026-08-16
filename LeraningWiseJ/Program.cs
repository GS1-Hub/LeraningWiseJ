using System;
using System.Collections.Specialized;
using Wisej.Web;

namespace LeraningWiseJ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">Arguments from the URL.</param>
        static void Main(NameValueCollection args)
        {
            Application.Desktop = new LayoutDesktop();

            Window1 window = new Window1();
            window.Show();
        }
    }
}