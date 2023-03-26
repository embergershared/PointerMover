/*
 * Copyright (c) 2023 Emmanuel Bergerat
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
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
                // ReSharper disable once LocalizableElement
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((services) => {
                    services.AddSingleton<ILanguagesCollections, LanguagesCollections>();
                    services.AddTransient<IPointerMover, PointerMover>();
                    if (Config != null) _ = services.AddSingleton(Config);
                    services.AddTransient<Main>();
                    services.AddLocalization();
                });
        }
    }
}