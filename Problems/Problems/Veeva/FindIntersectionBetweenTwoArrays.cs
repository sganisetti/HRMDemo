using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class FindIntersectionBetweenTwoArrays
    {
        public static int[] findIntersectionBetweenTwoArrays(int[] nums, int[] nums2)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            List<int> intersections = new List<int>();
            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }
            foreach (int num2 in nums2)
            {
                if (frequency.ContainsKey(num2) && frequency[num2] > 0)
                {
                    intersections.Add(num2);
                    frequency[num2]--;
                }
            }
            return intersections.ToArray();
        }
    }
}
