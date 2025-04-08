using ReportApp.Abstractions;
using ReportApp.Models;

namespace ReportApp.Services
{
    internal class RecordService : IRecordService
    {
        private List<Record> _records = new List<Record>();
        public List<Record> Records => _records;

        public void DeleteAllRecords() => _records.Clear();

        public double GetAllTotal() => _records.Sum(r => r.Bonuses);

        public List<Record> GetOpRecords(Operator op) => Records.Where(r => op.Ids.Contains(r.Id)).ToList();
        public double GetOpTotal(Operator op) => GetOpRecords(op).Sum(r => r.Bonuses);
    }
}
