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

        void AddOperator(string name, List<string> ids);

        void DeleteExistIds(string id);

        void DeleteAllOperators();

        void DeleteOperator(string selectedItem);

        void EditOperator(Operator opToEdit, List<string> newIds);

        void LoadExistData(string jsonFromFile);
    }
}
