using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class LongestPrefixOfAString
    {
        public static string FindLongestPrefixofString(string[] words)
        {
            Array.Sort(words);
            string str1 = words[0];
            string str2 = words[words.Length - 1];
            int index = 0;
            while (index < str1.Length)
            {
                if (str1[index] == str2[index])
                {
                    index++;
                }
                else
                {
                    break;
                }
            }

            return index == 0 ? " " : str1.Substring(0, index);


        }
    }
}
