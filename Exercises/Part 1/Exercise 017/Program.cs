using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string userInput = Console.ReadLine();
      int fnumber = Convert.ToInt32(userInput);

      Console.WriteLine("Give the second number!");
      string userInput1 = Console.ReadLine();
      int snumber = Convert.ToInt32(userInput1);

      int sum = fnumber + snumber;

      Console.WriteLine("The sum is " + sum);
    }
  }
}
