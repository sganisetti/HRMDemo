using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class FindShortestSubArray
    {

        public static int[] ShortestSubArrayOfTarget(int[] nums , int target)
        {
            int sum = 0;
            int start = 0;
            int Length = int.MaxValue;
            int[] result = { -1, -1 };
            for(int end = 0; end < nums.Length; end++)
            {
                sum = sum + nums[end];
                while(sum >= target)
                {
                    if(sum == target && (end - start+1) < Length)
                    {
                        Length = end - start + 1;
                        result[0] = start;
                        result[1] = end;
                    }

                    sum = sum - nums[start];
                    start++;
                }
            }
            return result;
       
        }
        public static int[] FindSubarrayWithTargetSum(int[] nums, int target)
        {
            int start = 0;
            int currentSum = 0;
            int minLength = int.MaxValue;
            int[] result = new int[] { -1, -1 };

            for (int end = 0; end < nums.Length; end++)
            {
                currentSum += nums[end];

                while (currentSum > target && start <= end)
                {
                    currentSum -= nums[start];
                    start++;
                }

                if (currentSum == target)
                {
                    int length = end - start + 1;
                    if (length < minLength)
                    {
                        minLength = length;
                        result[0] = start;
                        result[1] = end;
                    }
                }
            }

            return result[0] == -1 ? new int[0] : result;
        }
    }
}
