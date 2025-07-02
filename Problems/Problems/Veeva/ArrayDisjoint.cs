using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class ArrayDisjoint
    {
        //  input : arr1 = 1,2,3, arr2=4,5,6
        // both arrays have any similar number so we need to return true; other wise it's false
        public static bool AreArrayDisJoint(int[] nums1,int[] nums2)
        {
            Dictionary<int,bool> map = new Dictionary<int,bool>();
            foreach(int num in nums1)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, true);
                }
            }
            foreach(int num in nums2)
            {
                if (map.ContainsKey(num))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
