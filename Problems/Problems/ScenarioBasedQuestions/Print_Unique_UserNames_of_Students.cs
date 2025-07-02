using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.ScenarioBasedQuestions
{
    public class Print_Unique_UserNames_of_Students
    {

        public static bool ValidUserName(string userName)
        {
            foreach(char c in userName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static void CheckMethod()
        {
            HashSet<string> names = new HashSet<string>();
            Console.WriteLine("Enter the number of names you want to check");
            int numberofnames = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofnames; i++)
            {
                Console.WriteLine($"Please enter username  +   {i + 1}");
                string username = Console.ReadLine();
                if (ValidUserName(username) && !names.Contains(username))
                {
                    names.Add(username);
                    Console.WriteLine("Valid");
                }

                else
                {
                    Console.WriteLine("Invalid");
                }



            }
            Console.WriteLine("Valid Usernames are");

            foreach(string validnames in  names)
            {
                Console.WriteLine(validnames);
            }
        }
    }
}
