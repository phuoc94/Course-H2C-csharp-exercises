using System;
using System.Security.Cryptography.X509Certificates;

namespace exercise_61
{
    class Program
    {
        public static void Main(String[] args)
        {
            //PrintRightTriangle(4);
            ChristmasTree(10);

        }

        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
        }

        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintRightTriangle(int size)
        {
            for (int y = 1; y <= size; y++)
            {
                PrintSpaces(size - y);
                PrintStars(y);
                Console.WriteLine("");
            }

        }

        public static void ChristmasTree(int height)
        {
            int star = 1;
            for (int y = 0; y < height; y++)
            {
                PrintSpaces(height - y);
                PrintStars(star);
                Console.WriteLine("");
                star = star + 2;
            }
            for (int y = 0; y < 2; y++)
            {
                PrintSpaces((star - 3) / 2);
                PrintStars(3);
                Console.WriteLine("");
            }
        }
    }
}
