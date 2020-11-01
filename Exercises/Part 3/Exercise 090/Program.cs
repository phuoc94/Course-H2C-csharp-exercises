using System;
using System.Collections.Generic;

namespace exercise_90
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            while (true)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                string[] words = userInput.Split(',');
                int age = Convert.ToInt32(words[1]);
                if (age > oldest)
                {
                    oldest = age;
                }
            }
            Console.WriteLine($"Age of the oldest: " + oldest);



        }
    }
}



