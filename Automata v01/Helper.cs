using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_v01
{
    class Helper
    {
        internal static List<char> UpperLetters(string input)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                result.Add(c);
            }

            return result.ToList();
        }

        internal static string FormatAsSet(List<string> input)
        {
            // q0 q1 q2 => {q0,q1,q2}
            string result = "{";
            foreach (string s in input)
            {
                result += s + ",";
            }

            result = result.Remove(result.Length - 1, 1); // sterge ultima virgula
            result += "}";

            return result;
        }

        internal static List<char> LowerLetters(string input)
        {
            HashSet<char> result = new HashSet<char>();

            foreach (char c in input)
            {
                if (char.IsLower(c))
                    result.Add(c);
            }

            return result.ToList();
        }

        internal static string CharListToString(List<char> charList)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in charList)
            {
                result.Append(c);
            }
            return result.ToString();
        }

        internal static List<char> StringToCharList(string input)
        {
            List<char> result = new List<char>();

            foreach (var c in input)
            {
                result.Add(c);
            }

            return result;
        }

        internal static string FormatAsSet(List<char> input)
        {
            // abc => {a,b,c}
            string result = "{";
            foreach (char c in input)
            {
                result += c + ",";
            }

            result = result.Remove(result.Length - 1, 1); // sterge ultima virgula
            result += "}";

            return result;
        }
        internal static string FormatAsSet(List<char> input, Color color)
        {
            StringBuilder result = new StringBuilder();
            result.Append("{");
            foreach (char c in input)
            {
                result.Append(ColoredChar(c, color));
                result.Append(ColoredChar(',',Color.FromName("Black")));
            }

            result = result.Remove(result.Length - 10, 10); // sterge ultima virgula si spanu'
            result.Append("}");

            return result.ToString();
        }

        internal static string ColoredString(string text, string colorName)
        {
            return $"<span style = \"color:{colorName}\">{text}</ span >";
        }

        public static string ColoredChar( char c,Color color)
        {
            return $"<span style = \"color:{color.Name}\">{c}</ span >";
        }

        internal static bool StringHasOnlyCharsFromCharList(string text, List<char> charList)
        {
            foreach (var c in text)
            {
                if (!charList.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
