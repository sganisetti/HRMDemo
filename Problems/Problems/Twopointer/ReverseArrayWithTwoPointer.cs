using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Twopointer
{
    internal class ReverseArrayWithTwoPointer
    {
        //  Input : 1 2 3 4 5 6 7
        // output : 7 6 5 4 3 2 1
        public static int[] ReverseArray(int[] nums)
        {
            int right = nums.Length - 1;
            int left = 0;
            while(left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;

            }
            return nums;
        }


    }
}
