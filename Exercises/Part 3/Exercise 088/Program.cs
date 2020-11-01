using System;
using System.Collections.Generic;

namespace exercise_88
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

                Console.WriteLine(words[0]);
            }
        }
    }
}



