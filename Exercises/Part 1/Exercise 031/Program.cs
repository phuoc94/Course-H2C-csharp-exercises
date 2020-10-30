using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userInput1 = Console.ReadLine();
      int number = Convert.ToInt32(userInput1);


    int remainder = number % 2;

    if (remainder == 0){
            Console.WriteLine("It is even.");
            }
    else {
            Console.WriteLine("It is odd.");
            }
    }
  }
}
