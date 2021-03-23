using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_v01
{
    static class AutomataUtils
    {
        public static void SaveToJson(string fileName, Automata a)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(a));
        }

        public static Automata LoadFromJson(string fileName)
        {
            return JsonConvert.DeserializeObject<Automata>(File.ReadAllText(fileName));
        }
    }
}
