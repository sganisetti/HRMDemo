using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class PrintCountofCharacters
    {
        public static string encoded(string Encode)
        //ip : "3a2bc2a";
        //O/p:  aaabbcaa
        {
            int i = 0;
            StringBuilder result = new StringBuilder();
            while (i < Encode.Length)
            {
                int count = 0;
                while (i < Encode.Length && char.IsDigit(Encode[i]))
                {
                    count = count * 10 + (Encode[i] - '0');
                    i++;
                }
                count = count == 0 ? 1 : count;
                if (i < Encode.Length)
                {
                    char c = Encode[i];
                    result.Append(c, count);
                    i++;
                }
            }
            return result.ToString();
        }
        public static string DecodeString(string Encode)
        {
            if (string.IsNullOrEmpty(Encode))
                return string.Empty;
            StringBuilder Decoded = new StringBuilder();

            int i = 0;
            while (i < Encode.Length)
            {
                int count = 0;

                while (i < Encode.Length && char.IsDigit(Encode[i]))
                {
                    count = count * 10 + (Encode[i] - '0');
                    i++;
                }
                if (i < Encode.Length && char.IsLetter(Encode[i]))
                {
                    char c = Encode[i];
                    i++;
                    count = (count == 0) ? 1 : count;
                    Decoded.Append(new string(c, count));
                }
            }
            return Decoded.ToString();
        }
    }
}
