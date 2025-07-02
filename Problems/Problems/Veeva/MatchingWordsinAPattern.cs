using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Veeva
{
    internal class MatchingWordsinAPattern
    {

        public static List<string> FindMatchingWordsinString(string text, List<string> patterns)
        {
            HashSet<string> pattern = new HashSet<string>(patterns);
            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> matchingwords = new List<string>();
            foreach(string word in words)
            {
                foreach(string patternword in pattern)
                {
                    if (word.Contains(patternword))
                    {
                        matchingwords.Add(word);
                       // break;
                    }
                }
            }
            return matchingwords;
        }

        public static List<string> FindMatchingWords(string text, List<string> patterns)
        {
            // Create a hash set for patterns for quick lookup
            HashSet<string> patternSet = new HashSet<string>(patterns);

            // Split the text into words
            string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize a list to store matching words
            List<string> matchingWords = new List<string>();

            // Iterate through each word in the text
            foreach (string word in words)
            {
                foreach (string pattern in patternSet)
                {
                    // Check if the word contains the pattern
                    if (word.Contains(pattern))
                    {
                        matchingWords.Add(word);
                        break; // Avoid adding duplicates for the same word
                    }
                }
            }

            return matchingWords;
        }
    }
}
