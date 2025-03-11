using CsvHelper.Configuration;
using CsvHelper;
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
