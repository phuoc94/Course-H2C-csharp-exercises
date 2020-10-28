using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string userInput = Console.ReadLine();
      int days = Convert.ToInt32(userInput);
      int seconds = days * 24 * 60* 60;
      Console.WriteLine(seconds);
    }
  }
}
