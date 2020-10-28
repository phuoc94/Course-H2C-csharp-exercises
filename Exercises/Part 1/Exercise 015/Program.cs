using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string stRing = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string userInput = Console.ReadLine();
      int iTeger = Convert.ToInt32(userInput);
      Console.WriteLine("Give a double:");
      userInput = Console.ReadLine();
      double douBle = Convert.ToDouble(userInput);
      Console.WriteLine("Give a boolean:");
      userInput = Console.ReadLine();
      bool booLean = System.Convert.ToBoolean(userInput);
      Console.WriteLine("Your string: " + stRing);
      Console.WriteLine("Your integer: " + iTeger);
      Console.WriteLine("Your double: " + douBle);
      Console.WriteLine("Your boolean: " + booLean);
    }
  }
}
