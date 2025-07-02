using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.OOPS
{
    internal class Encapsulation
    {

        private static int _age;
        private static string _name;

        public static int myage
        {
            set
            {
                if (value < 18)
                {
                    throw new Exception("Age must be greater than 18");
                }
                _age = value;
            }

            get
            {
                return _age;
            }
        }
        public static void printDetais()
        {
            Console.WriteLine(myage);
        }
    }
}
