using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Automata_v01
{
    public class Automata
    {
        #region data
        List<char> i = new List<char>();
        List<string> s = new List<string>();
        List<string> sf = new List<string>();
        List<Tranzitie> f = new List<Tranzitie>();

        public List<char> I { get => i; set => i = value; }
        public List<string> S { get => s; set => s = value; }
        public List<string> Sf { get => sf; set => sf = value; }
        public List<Tranzitie> F { get => f; set => f = value; }

        internal string GetTranzitiiAsString()
        {
            StringBuilder s = new StringBuilder();

            foreach (var t in F)
            {
                s.Append(t.PerecheDeIntrare.ToString() + " → " + t.StareDeIesire);
                s.AppendLine();
            }

            return s.ToString();
        }

        #endregion

    }
}