using DatingApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Interfaces
{
    public interface IDataProcessor
    {
        public List<Record> ProcessData(IEnumerable<string> filePaths);

    }
}
