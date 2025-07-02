using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Programs
{
    internal class PrimeNumbers
    {
        public static void Primenumber() {
            for (int num = 2; num <= 100; num++)
            {
                bool isprime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine(num + " ");
                }
            }

        }
    }
}
