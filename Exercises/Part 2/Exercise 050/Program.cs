using System;

namespace exercise_50
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Call your method here:
            Console.WriteLine("How may times?");
            int times = Convert.ToInt32(Console.ReadLine());

            while (times > 0)
            {
                PrintPhrase();
                times--;
            }
        }

        // Write your method here:
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}
