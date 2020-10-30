﻿using System;

namespace exercise_60
{
    class Program
    {
        public static void Main(String[] args)
        {
            PrintStars(5);
            PrintSquare(4);
            PrintRectangle(17, 3);
            PrintTriangle(4);
        }


        public static void PrintStars(int number)
        {
            // you can print one star with the command
            // Console.Write("*");
            // call the print command n times
            // in the end print a line break with the comand
            // Console.WriteLine("");
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintSquare(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public static void PrintRectangle(int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < y + 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
