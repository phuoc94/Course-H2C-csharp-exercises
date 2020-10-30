using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      for (int i = number; i <= 100; i++) {
            Console.WriteLine(i);
            }
    }
  }
}
