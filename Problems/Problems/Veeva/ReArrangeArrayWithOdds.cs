using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class ReArrangeArrayWithOdds
    {
        public static int[] RearrangeArray_Odds(int[] nums)
        {
            List<int> odds = new List<int>();
            List<int> even = new List<int>();
            foreach(int num in nums)
            {
                if(num %2 != 0)
                {
                    odds.Add(num);

                }
                else
                {
                    even.Add(num);
                }
            }
            odds.AddRange(even);
            return odds.ToArray();
        }
    }
}
