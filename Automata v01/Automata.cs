using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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

        #endregion
        internal void MockData()
        {
            I.AddRange(new List<char> { 'a', 'b', 'c' });
            S.AddRange(new List<string> { "q0","q1","q2"});
            Sf.Add("q2");

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q0", 'a'),
                StareDeIesire = "q0"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q0", 'b'),
                StareDeIesire = "q1"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q0", 'c'),
                StareDeIesire = "q1"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q1", 'a'),
                StareDeIesire = "q1"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q1", 'b'),
                StareDeIesire = "q1"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q1", 'c'),
                StareDeIesire = "q2"
            });


            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q2", 'a'),
                StareDeIesire = "q2"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q2", 'b'),
                StareDeIesire = "q2"
            });

            F.Add(new Tranzitie
            {
                PerecheDeIntrare = ("q2", 'c'),
                StareDeIesire = "q2"
            });
        }

     
    }
}