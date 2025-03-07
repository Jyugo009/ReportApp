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
            IRecordService recordService = new RecordService();
            IDataProcessor dataProcessor = new CsvDataProcessor(recordService);

            Application.Run(new MainForm(opService, dataProcessor, recordService));

        }
    }
}