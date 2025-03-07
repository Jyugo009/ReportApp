using DatingApp.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void EditOperator(Operator opToEdit, List<string> newIds)
        {
            opToEdit.Ids.Clear();

            opToEdit.Ids = newIds;

            foreach (var id in newIds)
            {
                DeleteExistIds(id);
            }

            string json = JsonConvert.SerializeObject(Operators);

            File.WriteAllText("operators.json", json);

        }
        


        public void LoadExistData(string jsonFromFile)
        {
            if (jsonFromFile != null)
            {
                var list = JsonConvert.DeserializeObject<List<Operator>>(jsonFromFile);
                foreach (var item in list)
                {
                    AddOperator(item.Name, item.Ids);
                }    
            }
            else
            {

                MessageBox.Show("Данные с предыдущего сеанса утеряны! Возможно, был удален файл operators.json!");
            }
        }
    }
}
