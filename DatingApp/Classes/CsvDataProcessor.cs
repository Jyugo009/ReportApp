using CsvHelper;
using DatingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Classes
{
    internal class CsvDataProcessor : IDataProcessor
    {
        private readonly IRecordService _recordService;

        public CsvDataProcessor(IRecordService recordService)
        {
            _recordService = recordService;
        }
        public List<Record> ProcessData(IEnumerable<string> filePaths)
        {
            foreach (string filePath in filePaths)
            {
                try
                {
                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var newRecords = csv.GetRecords<Record>().ToList();
                        _recordService.Records.AddRange(newRecords);
                    }
                }
                catch(Exception ex) 
                { 
                    MessageBox.Show("Ошибка! Убедитесь, что выбран файл формата .csv с необходимыми полями.");
                }
            }

            _recordService.Records.AddRange(_recordService.Records);

            var consolidatedRecords = _recordService.Records.GroupBy(r => r.Id)
            .Select(grp => new Record(grp.Sum(r => r.Bonuses), grp.Key, grp.First().Lady)).ToList();

            return consolidatedRecords;
        }
    }
}
