using System;

namespace exercise_22
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

      Console.WriteLine("Give the third number!");
      string userInput3 = Console.ReadLine();
      int tnumber = Convert.ToInt32(userInput3);

      double sum = fnumber + snumber + tnumber;
      double avg = sum / 3;

      Console.WriteLine("The average is " + avg);
    }
  }
}
