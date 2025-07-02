using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class identifyPattern
    {

        //public static void Main(string[] args)
        //{
        //    //Console.WriteLine ("Try programiz.pro");
        //    List<string> list = new List<string> { "badc", "abab", "dddd", "dede", "yyxx" };
        //    string pattern = "baba";
        //    List<string> patterns = matchPattern(list, pattern);
        //    Console.WriteLine(string.Join(",", patterns));

        //    // List<int> encoded = EncodePattern(pattern);
        //    //Console.WriteLine(string.Join(",",encoded));

        //}
        public static List<string> matchPattern(List<string> patterns, string str)
        {
            List<int> sequence_Encoded = EncodePattern(str);
            List<string> result = new List<string>();
            foreach (string pattern in patterns)
            {
                if (EncodePattern(pattern).SequenceEqual(sequence_Encoded))
                {
                    result.Add(pattern);

                }
            }
            return result;
        }

        public static List<int> EncodePattern(string str)
        {
            Dictionary<char, int> pattern = new Dictionary<char, int>();
            int index = 0;
            List<int> Encodes = new List<int>();
            foreach (char c in str)
            {
                if (!pattern.ContainsKey(c))
                {
                    pattern[c] = index++;
                }
                Encodes.Add(pattern[c]);

            }
            return Encodes;
        }
    }
}
