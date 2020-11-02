using System;
using System.IO;

namespace exercise_117
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the file name and print the content of the file

            Console.WriteLine("Which file should have its contents printed? ");
            string userInput = Console.ReadLine();
            string filename = userInput;
            string path = @"C:\Users\phuoc\Source\Repos\phuoc94\H2C-csharp-exercises\Exercises\Part 4\Exercise 117\" + filename;

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

        }
    }
}
