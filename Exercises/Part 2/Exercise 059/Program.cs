using System;

namespace exercise_59
{
    class Program
    {
        public static void Main(String[] args)
        {
            int answer = Greatest(2, 7, 3);
            Console.WriteLine("Greatest: " + answer);
        }

        // Write your method here:
        public static int Greatest(int number1, int number2, int number3)
        {
            int g = number1;
            if (number2 > g)
            {
                g = number2;
            }
            else if (number3 > g)
            {
                g = number3;
            }
            return g;
        }
    }
}
