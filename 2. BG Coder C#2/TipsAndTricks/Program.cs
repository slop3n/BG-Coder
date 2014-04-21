using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Set");
            HashSet<int> words = new HashSet<int>();
            words.Add(1);
            words.Add(2);
            words.Add(3);
            words.Add(8);
            words.Add(4);
            words.Remove(2);
            words.Contains(2);
            foreach (var value in words)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(words.Contains(2));
            Console.WriteLine("\n\nSorted Set");
            SortedSet<int> sortedNumbers = new SortedSet<int>();
            sortedNumbers.Add(2);
            sortedNumbers.Add(1);
            sortedNumbers.Add(0);
            sortedNumbers.Add(2);
            sortedNumbers.Add(4);
            foreach (var value in sortedNumbers)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\n\nDictionary");

            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("pesho", "444");

            //dict["pesho"] = "gosho";

            string peshoResult = dict["pesho"];
            Console.WriteLine(dict.ContainsKey("pesho"));
            Console.WriteLine(peshoResult);
        }
    }
}
