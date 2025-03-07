using DatingApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
