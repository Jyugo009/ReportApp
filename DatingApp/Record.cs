using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    public class Record
    {
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(MyDoubleConverter))]
        public double bonuses { get; set; }

        public string id {  get; set; }

        public string lady { get; set; }    

        
    }
}
