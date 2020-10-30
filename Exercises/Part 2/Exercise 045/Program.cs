using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      for (int i = 0; i <= number; i++) {
            Console.WriteLine(i);
            }

    }
  }
}
