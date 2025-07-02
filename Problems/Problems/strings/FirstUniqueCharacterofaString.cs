using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class FirstUniqueCharacterofaString
    {
        public static int FindfirstUniquecharecterofstring(string str)
        {
            int[] freques = new int[25];
          char[] arr =   str.ToCharArray();
            foreach(char c in arr)
            {
                freques[c - 'a']++;

                for(int i = 0;i < arr.Length; i++)
                {
                    if (freques [arr[i] - 'a'] == 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
