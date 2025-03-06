using DatingApp.Classes;
using DatingApp.Interfaces;

namespace DatingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            IOperatorService opService = new OperatorService();
            IDataProcessor dataProcessor = new CsvDataProcessor(opService);

            Application.Run(new MainForm(opService, dataProcessor));

        }
    }
}