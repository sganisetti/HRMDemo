using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class Anagram
    {
        public static bool ISAnagram(string s1,string s2)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            if(s1.Length!=s2.Length) 
                return false;
         // char[] arr1 =   s1.ToCharArray();
          //  char[] arr2 = s2.ToCharArray();
            foreach(char c in s1)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }
            }
            foreach(char c in s2)
            {
                if (!map.ContainsKey(c))
                {
                    return false;
                }
                map[c]--;
                if (map[c] == 0)
                {
                    map.Remove(c);
                }
            }
            return map.Count == 0;
          
        }

        public static bool AreAnagrams(string s1, string s2)
        {
            // If lengths are not equal, they cannot be anagrams
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // Create a map to count characters in the first string
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            foreach (char c in s1)
            {
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c]++;
                }
                else
                {
                    charCountMap[c] = 1;
                }
            }

            // Decrement the count for characters in the second string
            foreach (char c in s2)
            {
                if (!charCountMap.ContainsKey(c))
                {
                    return false; // Character not found in the first string
                }

                charCountMap[c]--;

                // If count becomes zero, remove the character from the map
                if (charCountMap[c] == 0)
                {
                    charCountMap.Remove(c);
                }
            }

            // If the map is empty, the strings are anagrams
            return charCountMap.Count == 0;
        }
    }
}
