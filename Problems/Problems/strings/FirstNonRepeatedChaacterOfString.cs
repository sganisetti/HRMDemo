using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class FirstNonRepeatedChaacterOfString
    {

        public static void FindFirstNonRepeatedCharacterOfAstring()
        {
            string str = "AUTOMATION";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (KeyValuePair<char, int> data in dict)
            {
                if (data.Value == 1)
                {
                    Console.WriteLine(data.Key);
                    break;
                }
            }
        }
    }
}
