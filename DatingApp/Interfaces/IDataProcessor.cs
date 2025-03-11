using DatingApp.Classes;

namespace DatingApp.Interfaces
{
    public interface IDataProcessor
    {
        public List<Record> ProcessData(IEnumerable<string> filePaths);

    }
}
