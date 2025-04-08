using ReportApp.Models;

namespace ReportApp.Abstractions
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
