using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace histogram
{
    class Program
    {
        static void Main()
        {
            var input = "test artur test test artur lol aa bb lolek lol";              
            foreach (var item in HistogramWords(input))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            Console.ReadKey();
        }

        static Dictionary<string, int> HistogramWords(string input)
        {
            var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            var wordPattern = new Regex(@"\w+");
            foreach (Match match in wordPattern.Matches(input))
            {
                int currentCount = 0;
                words.TryGetValue(match.Value, out currentCount);
                currentCount++;
                words[match.Value] = currentCount;
            }
            return words;
        }
    }
}
