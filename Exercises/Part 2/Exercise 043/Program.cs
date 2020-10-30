using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("give number");
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);
      
      if(number < 0){
            number = number * -1;
            }

      Console.WriteLine(number);
    }
  }
}
