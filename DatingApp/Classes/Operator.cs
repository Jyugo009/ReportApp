using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Classes
{
    public class Operator
    {
        public string Name;

        public List<string> Ids;

        public Operator(string name, List<string> ids)
        {
            Name = name;
            Ids = ids;
        }
    }
}
