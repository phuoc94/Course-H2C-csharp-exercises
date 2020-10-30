using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("give number");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);

      Console.WriteLine(number*number);
      
    }
  }
}
