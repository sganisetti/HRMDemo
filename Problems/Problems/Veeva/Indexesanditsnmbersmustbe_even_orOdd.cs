using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class Indexesanditsnmbersmustbe_even_orOdd
    {
        public static bool AreIndicesAndValuesMatching(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0 && nums[i] % 2 != 0)
                {
                    return false;
                }
                if (i % 2 != 0 && nums[i] % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
