namespace Automata_v01
{
    public class Tranzitie
    {
        // f(q1,b) -> q2
        (string stare, char input) perecheDeIntrare; // (S,I)
        string stareDeIesire; // din S

        public (string stare, char input) PerecheDeIntrare { get => perecheDeIntrare; set => perecheDeIntrare = value; }
        public string StareDeIesire { get => stareDeIesire; set => stareDeIesire = value; }
    }
}