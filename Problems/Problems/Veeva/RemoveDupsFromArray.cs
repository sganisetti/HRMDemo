using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class RemoveDupsFromArray
    {
        public static int[] RemoveDupsFromArray1(int[] nums)
        {
            List<int> uniques = new List<int>();
            foreach (int num in nums)
            {
                if (!uniques.Contains(num))
                {
                    uniques.Add(num);
                }

            }
            return uniques.ToArray();

        }
    }
}
