using System;

namespace exercise_23
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
      int sub = fnumber - snumber;
      int mul = fnumber * snumber;
      double div = (double)fnumber / snumber;
       

      Console.WriteLine($"{fnumber} + {snumber} = {sum}");
      Console.WriteLine($"{fnumber} - {snumber} = {sub}");
      Console.WriteLine($"{fnumber} * {snumber} = {mul}");
      Console.WriteLine($"{fnumber} / {snumber} = {div}");
    }
  }
}
