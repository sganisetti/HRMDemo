using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class RevWordsInString
    {
        public static void  RevWordsinString()
        {
            // O/P: tseT  noitamotuA  yb  gnisu  #C 
            string str = "Test Automation by using C#";
            string[] arr = str.Split(" ");
            string result = " ";
            foreach (string word in arr)
            {
                string rev = " ";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    rev = rev + word[i];
                }
                result = result + rev + " ";

            }
            Console.WriteLine(result);

        }
    }
    }

