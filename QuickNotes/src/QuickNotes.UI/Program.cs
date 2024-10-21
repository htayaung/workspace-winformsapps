using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using QuickNotes.Core.Interfaces;
using QuickNotes.Core.Services;
using QuickNotes.Data;
using QuickNotes.Data.Repositories;

namespace QuickNotes.UI
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var logger = LogManager.GetCurrentClassLogger();
            try
            {
                var services = new ServiceCollection();

                // Configure Services
                ConfigureServices(services);

                ServiceProvider = services.BuildServiceProvider();

                ApplicationConfiguration.Initialize();
                Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of unhandled exception.");
                throw;
            }
            finally
            {
                LogManager.Shutdown();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var appSettings = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();
            services.AddSingleton<IConfiguration>(config => appSettings);

            services.AddDbContext<ApplicationDbContext>();

            // Forms
            services.AddTransient<FrmMain>();

            // Services
            services.AddTransient<ApplicationDbContext>();
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<INoteRepository, NoteRepository>();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                loggingBuilder.AddNLog();
            });
        }
    }
}