using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    internal class RemoveDuplicates
    {
        public static ArrayList RemoveDups(ArrayList list)
        {
           // list = new ArrayList() { 1, 2, 3, 4, 5, 6, 4, 3 };
            HashSet<int> unique = new HashSet<int>();
            ArrayList result = new ArrayList();
            foreach (int digit in list)
            {
                if (unique.Add(digit))
                {
                    result.Add(digit);

                }

            }
            return result;
        }
    }
}
