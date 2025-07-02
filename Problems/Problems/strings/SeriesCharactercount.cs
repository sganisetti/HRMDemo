using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.strings
{
    internal class SeriesCharactercount
    {
       public static string CompressString(string input)
        {
            // Step 1: Handle empty or null input
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Step 2: Initialize a StringBuilder for the result
            StringBuilder result = new StringBuilder();

            // Step 3: Initialize a count variable for tracking consecutive characters
            int count = 1;

            // Step 4: Iterate through the input string starting from the second character
            for (int i = 1; i < input.Length; i++)
            {
                // Step 5: Check if the current character matches the previous one
                if (input[i] == input[i - 1])
                {
                    // Increment the count if they match
                    count++;
                }
                else
                {
                    // Step 6: Append the previous character to the result
                    result.Append(input[i - 1]);

                    // Step 7: Append the count if it is greater than 1
                    if (count > 1)
                    {
                        result.Append(count);
                    }

                    // Reset the count for the new character
                    count = 1;
                }
            }

            // Step 8: Handle the last character and its count
            result.Append(input[^1]); // Append the last character
            if (count > 1)
            {
                result.Append(count); // Append the count if greater than 1
            }

            // Step 9: Return the compressed string
            return result.ToString();
        }
    }
}
