using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Programs
{
    internal class ArmStrongNumber
    {
        public static void ArmStrongnumber()
        {
            int num = 153;
            int sum = 0;
            int orgnum = num;
            while (num > 0)
            {
                int reminder = num % 10;
                num = num / 10;
                sum = sum + reminder * reminder * reminder;
                Console.WriteLine(sum);

            }
            if (sum == orgnum)
            {
                Console.WriteLine("This is a Arm strong number" + " " + orgnum);
            }
            else
            {
                Console.WriteLine("This is not a armstrong num " + orgnum);
            }
        }
    }
}
