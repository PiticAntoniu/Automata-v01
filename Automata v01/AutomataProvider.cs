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

        public static Automata A { get => a == null ? a = new Automata() : a; set => a = value; }
    }
}
