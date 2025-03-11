using DatingApp.Interfaces;
using Newtonsoft.Json;

namespace DatingApp.Classes
{
    internal class OperatorService : IOperatorService
    {
        private List<Operator> _operators = new List<Operator>();
        public List<Operator> Operators => _operators;


        public void AddOperator(string name, List<string> ids)
        {
            Operator newOp = new Operator(name, ids);

            foreach (var id in newOp.Ids)
            {
                DeleteExistIds(id);
            }

            Operators.Add(newOp);
        }

        public void DeleteOperator(string selectedItem)
        {
            if (selectedItem != null)
            {
                string opName = selectedItem.Split(':')[0];

                MessageBox.Show("Оператор " + opName + " удален.");

                var opToRemove = Operators.FirstOrDefault(op => op.Name == opName);

                if (opToRemove != null)
                    Operators.Remove(opToRemove);
                else
                    MessageBox.Show($"Оператор {opName} не найден!");
            }
            else
            {
                MessageBox.Show("Что-то пошло не так.");
            }
        }

        public void DeleteAllOperators() => Operators.Clear();

        public Operator GetOperator(string name) => Operators.FirstOrDefault(op => op.Name == name); 

        public void DeleteExistIds(string id)
        {
            foreach (Operator op in Operators)
            {
                if (op.Ids.Contains(id))
                {
                    op.Ids.Remove(id);
                }
            }

        }

        public void EditOperator(Operator operatorToEdit, List<string> newIds)
        {
            operatorToEdit.Ids.Clear();

            for (int i = newIds.Count - 1; i >= 0; i--)
            {
                DeleteExistIds(newIds[i]);
            }

            operatorToEdit.Ids = newIds;

            string json = JsonConvert.SerializeObject(Operators);

            File.WriteAllText("operators.json", json);

        }
        


        
    }
}
