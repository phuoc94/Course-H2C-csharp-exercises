using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            int longest = 0;
            string longname = "";

            while (true)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                string[] words = userInput.Split(',');
                int age = 2020 - Convert.ToInt32(words[1]);
                if (age > oldest)
                {
                    oldest = age;
                }
                int length = words[0].Length;
                if (length > longest)
                {
                    longname = words[0];
                    longest = length;
                }
            }
            Console.WriteLine($"Longest name: " + longname);
            Console.WriteLine($"Highest age: " + oldest);
        }
    }
}



