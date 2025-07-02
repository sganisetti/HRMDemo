using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class ReplaceCharactersWithitsOccurences
    {

        public static string ReplacescharacterswithitsOccurences(string str)
        {
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (charcount.ContainsKey(c))
                {
                    charcount[c]++;
                }
                else
                {
                    charcount[c] = 1;
                }
            }
            foreach (char c in str)
            {
               
                
                    result.Append(charcount[c]);
             
            }
            return result.ToString();
        }
        // if Repalace characters with is occurences if it is greaterthan 1
        public static string ReplacestringwithitsOccurences2(string str)
        {
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (charcount.ContainsKey(c))
                {
                    charcount[c]++;
                }
                else
                {
                    charcount[c] = 1;
                }
            }
            foreach (char c in str)
            {
                if (charcount[c] > 1)
                {
                    result.Append(charcount[c]);
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
