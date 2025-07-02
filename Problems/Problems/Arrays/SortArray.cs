using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    internal class SortArray
    {
        public static int[] sortArray(int[] nums)
        {
            for(int i =0;i< nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
                Console.Write(nums[i]+ " ");
            }
          
            return nums;

        }
    }
}
