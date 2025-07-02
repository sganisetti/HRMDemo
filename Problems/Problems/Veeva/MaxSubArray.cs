using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class MaxSubArray
    {
        public static int FindMaxSubArray(int[] nums)
        {
            int sum = 0;
            int max_sum = nums[0];
            for(int i =0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(sum > max_sum)
                {
                    max_sum = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            return max_sum;
        }
    }
}
