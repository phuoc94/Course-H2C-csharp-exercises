using System;

namespace exercise_29
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



    if (number1 > number2){
            Console.WriteLine($"The larger number is {number1}!");
            }
    else if (number1 < number2){
            Console.WriteLine($"The larger number is {number2}!");
            }
    else{
            Console.WriteLine("They are equal!");
            }
    }
  }
}
