using ReportApp.Models;

namespace ReportApp.Abstractions
{

    public interface IDataProcessor
    {
        public List<Record> ProcessData(IEnumerable<string> filePaths);

    }
}
