using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Dicyionarys
{
    internal class Dict1
    {
        public static void meth1()
        {
            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("sairam", "33221144");
            dict.Add("balaji", "33221145");
            dict.Add("charan", "33221147");
            dict.Add("sudheer", "33221148");
            if(dict.TryGetValue("sairam", out string value))
            {
                Console.WriteLine($"sairam's phone num is {value}");
            }
            string phonenumber = dict["balaji"];
            Console.WriteLine($"Balaji's phonenum is {phonenumber }");
            if (dict.ContainsKey("charan"))
            {
                Console.WriteLine(dict["charan"]);

            }
        }

        public static void meth2()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("sairam", "50000");
            dict.Add("sree charan", "100000");
            dict.Add("Konda reddy", "125000");
            dict.Add("sudheer", "30000");
            string secondhighest = dict.OrderByDescending(e => e.Value).Skip(1).First().Key;
            Console.WriteLine(secondhighest);

        }
    }
}
