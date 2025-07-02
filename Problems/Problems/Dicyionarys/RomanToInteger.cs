using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Dicyionarys
{
    public class RomanToInteger
    {
        public static int RomantoIntegerConverter(string roman)
        {
            //IV
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            
            };
            int total = 0;
            int previousvalue = 0;

            foreach (char c in roman)
            {
                int currentvalue = map[c];
                if(currentvalue > previousvalue)
                {
                    total += currentvalue - 2 * previousvalue;
                }
                else
                {
                    total += currentvalue;
                }
                previousvalue = currentvalue;

            }
            return total;
        }

    }
}
