using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class ClomvertCamelToSnakeCase
    {

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Try programiz.pro");
        //    string input = "camelCase";
        //    string result = convertCamelToSnakeCase(input);
        //    Console.WriteLine(result);

        //}

        public static string convertCamelToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    if (result.Length > 0)
                    {
                        result.Append("_");
                    }
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }


            }
            return result.ToString();
        }
    }
}
