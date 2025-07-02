using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class MoveZerosToEnd
    {

        public static void MoveZeros(int[] nums)
        {
            //0, 1, 0, 3, 12
            int nonzeroindex = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[nonzeroindex];
                    nums[nonzeroindex] = nums[i];
                    nums[i] = temp;
                    nonzeroindex++;
                }
            }
        }
    }
}
