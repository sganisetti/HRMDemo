using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class Multiplicationofarray
    {
        public static int[] Multiplicationfothernumbers1()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int[] ans = new int[arr.Length];
            int idx = 0, len = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                int mul = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        mul = mul * arr[j];
                }
                ans[idx] = mul;
                idx++;
            }
            for (int i = 0; i < arr.Length; i++) { 
                Console.Write(ans[i] + " ");
        }
            return ans;
    }
    }
}
