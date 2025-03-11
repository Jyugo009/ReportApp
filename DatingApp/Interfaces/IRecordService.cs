using DatingApp.Classes;

namespace DatingApp.Interfaces
{
    public interface IRecordService
    {
        List<Record> Records { get; }
        void DeleteAllRecords();
        List<Record> GetOpRecords(Operator op);
        double GetOpTotal(Operator op);
        double GetAllTotal();
    }
}
