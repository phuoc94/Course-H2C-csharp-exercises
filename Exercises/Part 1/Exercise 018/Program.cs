using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:

      Console.WriteLine("Give the first number!");
      string userInput1 = Console.ReadLine();
      int number1 = Convert.ToInt32(userInput1);

      Console.WriteLine("Give the second number!");
      string userInput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userInput2);

      Console.WriteLine("Give the third number!");
      string userInput3 = Console.ReadLine();
      int number3 = Convert.ToInt32(userInput3);

      int sum = number1 + number2 + number3;

      Console.WriteLine("The sum is " + sum);
    }
  }
}
