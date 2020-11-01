using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace exercise_91
{
    class Program
    {
        public static void Main(string[] args)
        {
            int oldest = 0;
            string oldname = "";
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
                    oldname = words[0];
                    oldest = age;
                }
            }
            Console.WriteLine($"Name of the oldest: " + oldname);
        }
    }
}



