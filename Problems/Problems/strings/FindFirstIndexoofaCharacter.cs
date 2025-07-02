using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class FindFirstIndexoofaCharacter
    {
        public static int FindtheoccurenceofaString(string needle, string haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int j = 0;
                    int k = i;
                    while (j < needle.Length && k < haystack.Length && needle[j] == haystack[k])
                    {
                        j++;
                        k++;
                        if (j == needle.Length)
                        {
                            return i;
                        }
                    }
                }
            }



            return -1;
        }
    }
}
