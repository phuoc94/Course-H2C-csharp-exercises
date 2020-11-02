using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {

            int count = 0;
            while (true)
            {
                Console.Write(">");
                string userInput = Console.ReadLine();
                if (userInput == "end")
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
