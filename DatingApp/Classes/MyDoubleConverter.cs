using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.TypeConversion;

namespace DatingApp.Classes
{
    public class MyDoubleConverter : DoubleConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            string processedText = text.Replace("'", "");

            return base.ConvertFromString(processedText, row, memberMapData);
        }
    }
}
