using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class CanFormEvenOdd
    {
        public static bool CanFormEvenAndOdd(int[] nums)
        {
            if (nums.Length % 2 != 0) return false;
            int evenCount = 0;
            int oddCount = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            return evenCount == oddCount;

        }
    }
}
