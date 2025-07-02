using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class PrintSingleUniqueNumberinArray
    {
        //i/p 1,2,4,1,2
        // o/P ; 4
        public static int PrintSingleUniqueNumber(int[] nums)
        {
            HashSet<int> singleUniqueNumber = new HashSet<int>();
            foreach (int num in nums)
            {
                if (singleUniqueNumber.Contains(num))
                {
                    singleUniqueNumber.Remove(num);
                }
                else
                {
                    singleUniqueNumber.Add(num);
                }
            }

            foreach (int singlenum in singleUniqueNumber)
            {
                return singlenum;
            }
            return -1;
        }
    }
}
