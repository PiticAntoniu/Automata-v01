using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_v01
{
    class AutomataConvertor
    {
        public static string GetAutomataAsString(Automata a)
        {
            StringBuilder t = new StringBuilder();

            t.Append("I = " + Helper.FormatAsSet(a.I));
            t.AppendLine();
            t.Append("S = " + Helper.FormatAsSet(a.S));
            t.AppendLine();
            t.Append("Sf = " + Helper.FormatAsSet(a.Sf));
            t.AppendLine();

            t.Append("Tranzitii"); t.AppendLine();
            t.Append(a.GetTranzitiiAsString());

            return t.ToString();
        }
    }
}
