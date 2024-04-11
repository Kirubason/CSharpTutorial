using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Country
    {
        public static string States(params string[] States)
        {
            StringBuilder Totalstate = new StringBuilder();
            foreach(var state in States)
            {
                Totalstate.Append(state);
                Totalstate.Append(", ");
            }
            return Totalstate.ToString();
        }

    }
}
