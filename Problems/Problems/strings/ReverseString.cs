using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    public class ReverseString
    {
        public static void ReverseStringg()
        {
            string str = "Hello";
            string rev = "";
            Console.WriteLine(str.Length);
            for (int i = str.Length-1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }
    }
}
