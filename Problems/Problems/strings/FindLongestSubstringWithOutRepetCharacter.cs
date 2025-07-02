using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class FindLongestSubstringWithOutRepetCharacter
    {
        public static void FindLongestSubstringWithOutRepetCharacters(string str)
        {
            int start = 0;
            int end = 0;
            int maxLength = 0;
            List<char> chars = new List<char>();
            while (end < str.Length)
            {
                if (!chars.Contains(str[end]))
                {
                    chars.Add(str[end]);
                    end++;
                    maxLength = Math.Max(maxLength, chars.Count);
                }
                else
                {
                    chars.Remove(str[start]);
                    start++;
                }
            }
            Console.WriteLine($"Lenght of the longest SubArray {maxLength}");

        }
    }
}
