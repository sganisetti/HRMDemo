using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class SuMBetweentwo
    {
        public static int SumBetweenNthMaxMin(int[] nums, int n)
        {
            if (nums == null || nums.Length == 0 || n <= 0 || n > nums.Length)
            {
                throw new ArgumentException("Invalid input.");
            }

            // Use HashSet to find unique values
            HashSet<int> uniqueNums = new HashSet<int>(nums);

            // Find n-th maximum
            int nthMax = uniqueNums.OrderByDescending(x => x).Skip(n - 1).First();

            // Find n-th minimum
            int nthMin = uniqueNums.OrderBy(x => x).Skip(n - 1).First();

            // Get the indices of nthMax and nthMin
            int startIndex = Array.IndexOf(nums, nthMin);
            int endIndex = Array.IndexOf(nums, nthMax);

            // Ensure startIndex < endIndex
            if (startIndex > endIndex)
            {
                int temp = startIndex;
                startIndex = endIndex;
                endIndex = temp;
            }

            // Calculate the sum between indices
            int sum = 0;

            sum = sum  + nums[startIndex] + nums[startIndex+1]+nums[endIndex]+nums[endIndex-1];
            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    sum += nums[i];
            //}

            return sum;
        }
    }
}
