using System;
using System.Configuration;
using System.Windows.Forms;
using MainForm.Classes;
using MainForm.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; private set; }
        public static IConfigurationRoot? Config { get; private set; }


        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            #region Initializing Services

            // Loading settings
            Config = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            // Building Dependency Injection (ref: https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms)
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            #endregion

            // Launch Main form and fail gracefully, if Main launch failed.
            try
            {
                Application.Run(ServiceProvider.GetRequiredService<Main>());
            }
            catch (Exception e)
            {
                // If program launch failed, display error to the user
                var text = $"There was an error that caused the application to crash.\n\n{e}";
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((services) => {
                    services.AddSingleton<ILanguagesCollections, LanguagesCollections>();
                    if (Config != null) _ = services.AddSingleton(Config);
                    services.AddTransient<Main>();
                });
        }
    }
}