using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace exercise_110
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }
                items.Add(new Item(userInput));
            }
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}




