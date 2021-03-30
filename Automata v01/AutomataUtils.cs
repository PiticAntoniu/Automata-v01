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
        public static string stepByStepTranzitions;
        public static void SaveToJson(string fileName, Automata a)
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(a));
        }

        public static Automata LoadFromJson(string fileName)
        {
            return JsonConvert.DeserializeObject<Automata>(File.ReadAllText(fileName));
        }

        internal static bool CheckWord(Automata a, string word)
        {
            stepByStepTranzitions = "";
            // q0, abcbc
            string stareActuala = a.S[0]; // q0
            stepByStepTranzitions += "(" + stareActuala + "," + word +")\n";
            while (word != "" && a.ExistTransition(stareActuala, word[0]) ){
                stareActuala = a.Transition(stareActuala, word[0]);
                word = word.Remove(0, 1);
                stepByStepTranzitions += "(" + stareActuala + "," + word + ")\n";
            }

            return word=="" && a.Sf.Contains(stareActuala);
        }
    }
}
