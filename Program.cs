using Minecraft_Map_To_Image.src.views;
using System.Reflection;

namespace Minecraft_Map_To_Image
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SplashScreen scr = new();

            scr.Show();

            Application.Run();
        }
    }
}