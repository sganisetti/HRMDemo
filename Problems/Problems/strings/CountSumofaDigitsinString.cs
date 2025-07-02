using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    public class CountSumofaDigitsinString
    {
        public static void SumofDigitsinAString()
        {
            string str = "AB12CD3E4";
            int sum = 0;
            for(int  i = 0;i<str.Length;i++)
            {
                char c = str[i];
                if(c >='0' && c <= '9')
                {
                    sum = sum + c - '0';
                }
            }
            Console.WriteLine("sum of all digits in a string" +" "+  sum);
        }

        public static void SumofDigitsinAString2()
        {
            string str = "AB12CD3E4";
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
               
                if (str[i] >= '0' && str[i] <= '9')
                {
                    char c = str[i];
                    sum = sum + c - '0';
                }
            }
            Console.WriteLine("second sum of all digits in a string" + " " + sum);
        }
        
    }
}
