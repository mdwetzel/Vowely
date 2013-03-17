using System;
using System.Collections.Generic;
using System.Text;
using Extensions;

namespace Vowely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to count the vowels!: ");
            string input = Console.ReadLine();

            Dictionary<char, int> vowels = new Dictionary<char, int>();

            int vowelCount = 0;
            foreach (char c in input) {
                if (c.IsVowel()) {
                    vowelCount++;
                    if (!vowels.ContainsKey(c)) {
                        vowels[c] = 0;
                    }
                    vowels[c]++;
                }
            }

            Console.WriteLine("\nThere are {0} vowels in the string {1}! Isn't that just dandy?", vowelCount, input);

            Console.WriteLine("\nA little more info...\n");

            foreach (KeyValuePair<char, int> item in vowels) {
                Console.WriteLine("{0} occurs {1} times", item.Key, item.Value);
            }

            Console.WriteLine("\nThe more you know...");

            Console.ReadLine();
        }
    }
}
