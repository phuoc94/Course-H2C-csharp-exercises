using System;
using System.IO;

namespace exercise_116
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Read the file data.txt and print the text from it as it is
            // You can use either File.ReadAllText or File.ReadAllLines

            string filename = "data.txt";
            string path = @"C:\Users\phuoc\Source\Repos\phuoc94\H2C-csharp-exercises\Exercises\Part 4\Exercise 116\" + filename;
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
