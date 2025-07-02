using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class SortNegativesAndPositives
    {
        public static int[] SortNegativesAndPositivess(int[] nums)
        {
            //int[] numss = { 2, -1, -3, 5, -6, 8 }
            int negativeindex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    int temp = nums[negativeindex];
                    nums[negativeindex] = nums[i];
                    nums[i] = temp;
                    negativeindex++;
                }
            }
            return nums;
        }
    }
}
