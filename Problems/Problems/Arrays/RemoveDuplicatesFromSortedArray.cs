using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public static  int RemoveDuplicates(int[] nums)
        {
          //  int[] ints = { 1, 1, 2, 2, 2, 3, 3, 3 };
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }

            }
            return k;
        }
    }
}
