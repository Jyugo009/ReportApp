using ReportApp.Abstractions;
using Newtonsoft.Json;
using ReportApp.Models;

namespace ReportApp.Services
{
    public class SessionDataService : ISessionDataService 
    {
        private readonly IOperatorService _operatorService;

        public SessionDataService(IOperatorService operatorService)
        {
            _operatorService = operatorService;
        }
        public void StartSessionLoad() 
        {
            if (File.Exists("operators.json"))
            {
                string jsonFromFile = File.ReadAllText("operators.json");

                LoadData(jsonFromFile);

                
            }
        }

        public void LoadData(string jsonFromFile)
        {
            if (jsonFromFile != null)
            {
                var list = JsonConvert.DeserializeObject<List<Operator>>(jsonFromFile);
                foreach (var item in list)
                {
                    _operatorService.AddOperator(item.Name, item.Ids);
                }
            }
            else
            {
                MessageBox.Show("Данные с предыдущего сеанса утеряны! Возможно, был удален файл operators.json!");
            }
        }

        public void EndSessionSave()
        {
            string json = JsonConvert.SerializeObject(_operatorService.Operators);
            File.WriteAllText("operators.json", json);
        }
    }
}
