using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class MutiplyEvensinArray
    {
        // input : 1,2,3,4
        // output : 1,4,3,16
        public static int[] MultiplyEvensinArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] = nums[i] * nums[i];
                }

            }
            return nums;
        }
    }
}
