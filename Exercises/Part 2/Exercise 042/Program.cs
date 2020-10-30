using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("give number1");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      Console.WriteLine("give number2");
      string userInput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userInput2);

      double squareRoot = Math.Sqrt(number+number2);

      Console.WriteLine(squareRoot);
    }
  }
}
