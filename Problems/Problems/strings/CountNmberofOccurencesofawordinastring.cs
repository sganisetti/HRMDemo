using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    public class CountNmberofOccurencesofawordinastring
    {
        public static void NumberofRepeatedWordsinaString()
        {
            string str = "Java Test Automation C# Test Automation";
           string [] arr =   str.Split(" ");
            Dictionary<string,int> dict = new Dictionary<string,int>();

            foreach (string item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            foreach(KeyValuePair<string,int> pair in dict)
            {
                Console.WriteLine($"The word  {pair.Key} occured {pair.Value} Times");
            }
        }
    }
}
