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
        private readonly IOperatorService _operatorService;

        public CsvDataProcessor(IOperatorService operatorService)
        {
            _operatorService = operatorService;
        }
        public List<Record> ProcessData(IEnumerable<string> filePaths)
        {
            foreach (string filePath in filePaths)
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var newRecords = csv.GetRecords<Record>().ToList();
                    _operatorService.Records.AddRange(newRecords);
                }
            }

            _operatorService.Records.AddRange(_operatorService.Records);

            var consolidatedRecords = _operatorService.Records.GroupBy(r => r._id)
            .Select(grp => new Record(grp.Sum(r => r._bonuses), grp.Key, grp.First()._lady)).ToList();

            return consolidatedRecords;
        }
    }
}
