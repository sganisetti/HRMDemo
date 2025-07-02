using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Problems.strings
{
    public class CountOccuranceOfaCharacter
    {
        public static void CountOccuranceofACharacter()
        {
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            
            Console.WriteLine("Enter charater to count");
            char charctertocount = Console.ReadLine()[0];
            int count = 0;
            foreach(char c in str)
            {
                if(c == charctertocount) 
                    count++;
            }
            Console.WriteLine($"{charctertocount} occurs {count} times");
        }
    }
}
