using System;
using System.Collections.Generic;

namespace exercise_70
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int grEatest = list[0];
            foreach (int li in list)
            {
                if (li > grEatest)
                {
                    grEatest = li;
                }
            }
            Console.WriteLine($"The grEatest number: {grEatest}");
        }
    }
}
