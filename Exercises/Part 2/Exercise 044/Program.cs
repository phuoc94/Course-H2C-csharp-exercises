using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      string userInput = Console.ReadLine();
      int number = Convert.ToInt32(userInput);
      string userInput2 = Console.ReadLine();
      int number2 = Convert.ToInt32(userInput2);
      
      if(number > number2){
                Console.WriteLine($"{number} is grEater than {number2}.");
            }
      else if(number < number2){
                Console.WriteLine($"{number} is less than {number2}.");
            }
      else{
                Console.WriteLine($"{number} is equal to {number2}.");
            }
    }
  }
}
