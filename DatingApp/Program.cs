using DatingApp.Classes;
using DatingApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DatingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddSingleton<IOperatorService, OperatorService>();
            services.AddSingleton<IRecordService, RecordService>();
            services.AddTransient<IDataProcessor, CsvDataProcessor>();
            services.AddTransient<MainForm>();
            services.AddTransient<AddOperatorForm>();
            services.AddTransient<EditOperatorForm>();
            services.AddTransient<ReportForm>();
            services.AddTransient<ISessionDataService, SessionDataService>();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
                

        }
    }
}