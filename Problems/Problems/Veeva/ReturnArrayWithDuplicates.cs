using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class ReturnArrayWithDuplicates
    {
        public static int[] ArrayReturnsWithDuplicates(int[] nums)
        {
            HashSet<int> unique = new HashSet<int>();
            HashSet<int>dups = new HashSet<int>();
            foreach (int num in nums)
            {
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
                else
                {
                    dups.Add(num);
                }
            }
            return dups.ToArray();
        }


    }
}
