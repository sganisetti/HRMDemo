using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    public class CountNumberofOccurancesofaCharacter
    {

        public static void CountOccurancesofaeachcharacter()
        {

            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            char [] arr = str.ToCharArray();
            Dictionary<char,int > dict = new Dictionary<char,int>();
            foreach(char c in arr)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach(KeyValuePair<char,int> data in dict)
            {
                Console.WriteLine($"Character {data.Key} occuring {data.Value} times");
            }
        }
    }
}
