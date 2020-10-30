using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);
      Console.WriteLine("Where from?");

      string userInput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userInput2);

      for (int i = number2; i <= number; i++) {
            Console.WriteLine(i);
            }
    }
  }
}
