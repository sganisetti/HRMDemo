using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Sliding_TwoPointer_Technique
{
    internal class SlidingWindow
    {
        public static int WindowTech(int[] nums , int k,int target)
        {
            int windowsum = 0;
            for (int i = 0; i < k; i++)
            {
                windowsum += nums[i];
            }
            int totalsum = windowsum;
            for(int i = k; i < nums.Length; i++)
            {
                windowsum += nums[i] - nums[i - k];
              totalsum =   Math.Max(windowsum, totalsum);
                //if(totalsum == target)
                //{
                //    break;
                //}
            }
            return totalsum;
        }
        

    }
}
