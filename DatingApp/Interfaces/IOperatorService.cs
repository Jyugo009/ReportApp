using DatingApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Interfaces
{
    public interface IOperatorService
    {
        List<Operator> Operators { get; }

        List<Record> Records { get; }

        void AddOperator(string name, List<string> ids);

        void DeleteExistIds(string id);

        void DeleteAllOperators();

        void DeleteAllRecords();

        void DeleteOperator(string selectedItem);
        List<(string OperatorName, List<Record> Records, double TotalBonuses)> GetOperatorRecords(List<Record> consolidatedRecords);

        void EditOperator(Operator opToEdit, List<string> newIds);

        void LoadExistData(string jsonFromFile);
    }
}
