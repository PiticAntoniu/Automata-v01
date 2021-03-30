using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_v01
{
    static class AutomataProvider
    {
        static Automata a = null;

        public static Automata A { get  { if (a == null) return a = new Automata(); else return a; } set => a = value; }
    }
}
