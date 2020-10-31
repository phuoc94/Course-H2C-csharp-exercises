using System;
using System.Collections.Generic;

namespace exercise_86
{
    class Program
    {
        public static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine(word);
            }
        }
    }
}

