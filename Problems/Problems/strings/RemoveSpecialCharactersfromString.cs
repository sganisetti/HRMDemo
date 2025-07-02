using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class RemoveSpecialCharactersfromString
    {
        public static void RemoveSpecialCharacters()
        {
            string name = "Sairam@!%";
            char[] arr = name.ToCharArray();
            string orgName = "";

            foreach (char c in arr)
            {
                // Check if the character is a letter (uppercase or lowercase)
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >=0 && c <=9))
                {
                    orgName += c;
                }
            }

            Console.WriteLine("Original String: " + name);
            Console.WriteLine("Filtered String: " + orgName);
        }
    }
}
