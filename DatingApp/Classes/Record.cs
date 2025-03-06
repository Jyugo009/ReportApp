using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Classes
{
    public class Record
    {
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(MyDoubleConverter))]
        public readonly double _bonuses;
        public readonly string _id;
        public readonly string _lady;


        public Record(double bonuses, string id, string lady)
        {
            _bonuses = bonuses;
            _id = id;
            _lady = lady;
        }


    }
}
