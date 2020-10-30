using System;
using System.Collections.Generic;

namespace exercise_72
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            int Smallest = list[0];
            foreach (int li in list)
            {
                if (li < Smallest)
                {
                    Smallest = li;
                }
            }
            Console.WriteLine($"Smallest number: {Smallest}");

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == Smallest)
                {
                    Console.WriteLine($"Found at index: {i}");
                }
            }
        }
    }
}
