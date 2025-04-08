using ReportApp.Models;

namespace ReportApp.Abstractions
{
    public interface IOperatorService
    {
        List<Operator> Operators { get; }

        void AddOperator(string name, List<string> ids);

        void DeleteExistIds(string id);

        void DeleteAllOperators();

        Operator GetOperator(string name);

        void DeleteOperator(string selectedItem);

        void EditOperator(Operator opToEdit, List<string> newIds);
    }
}
