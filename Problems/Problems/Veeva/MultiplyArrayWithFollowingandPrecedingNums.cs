using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class MultiplyArrayWithFollowingandPrecedingNums
    {
        // ip : 1234
        // o/p 24,12,8,6
        public static int[] multiply_array_nums_with_following_preceding_numbers(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int mul = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        mul = mul * nums[j];

                    }
                    result[i] = mul;
                }
            }
            return nums;
        }
    }
}
