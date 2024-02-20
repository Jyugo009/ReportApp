using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    public class Operator
    {
        public string Name { get; set; }

        public List<string> Ids { get; set; }

        public void DeleteExistIds(string id, List<Operator> operators)
        {

            foreach (Operator op in operators)
            {
                if (op.Ids.Contains(id))
                {
                    op.Ids.Remove(id);
                }
            }

        }
    }
}
