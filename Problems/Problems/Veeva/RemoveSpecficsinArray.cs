using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class RemoveSpecficsinArray
    {
        public static int[] RemoveSpecificElement(int[] nums, int val)
        {
            List<int> specific = new List<int>();
            foreach (int num in nums)
            {
                if (num != val)
                {
                    specific.Add(num);
                }
            }
            return specific.ToArray();
        }

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Try programiz.pro");
        //    int[] nums = { 3, 2, 2, 3 };
        //    int value = 3;
        //    int[] specifics = RemoveSpecificElement(nums, value);
        //    Console.WriteLine(string.Join(",", RemoveSpecificElement(nums, value)));
        //}
    }
}
