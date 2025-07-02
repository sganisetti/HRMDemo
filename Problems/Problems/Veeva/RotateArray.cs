using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class RotateArray
    {


        public static void Reverse(int[] nums,int start,int end)
        {
            while(start< end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public static void Rotate(int[] nums , int k)
        {
            int n = nums.Length;
            Reverse(nums,0,n-1);
            Reverse(nums,0,k-1);
            Reverse(nums,k,n-1);
        }
    }
}
