using System;
using System.Collections.Generic;

namespace exercise_87
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                string[] words = userInput.Split(' ');

                foreach (var word in words)
                {
                    if (word.Contains("av"))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}

