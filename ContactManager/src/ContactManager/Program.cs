using ContactManager.Infrastructure;
using ContactManager.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;

namespace ContactManager
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
                var config = new ConfigurationBuilder()
                    .SetBasePath(basePath: Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();

                // Configure DI
                var serviceCollection = new ServiceCollection();
                ConfigureServices(serviceCollection);
                ServiceProvider = serviceCollection.BuildServiceProvider();

                ApplicationConfiguration.Initialize();
                Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program beceuse of unhandled exception.");
                throw;
            }
            finally
            {
                LogManager.Shutdown();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Forms
            services.AddTransient<FrmMain>();
            services.AddTransient<FrmSaveContact>();

            // Services
            services.AddTransient<ApplicationDbContext>();
            services.AddTransient<IContactService, ContactService>();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                loggingBuilder.AddNLog();
            });
        }
    }
}