using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      while(true){
            Console.WriteLine("Give a number:");
            string userInput1 = Console.ReadLine();
            int number = Convert.ToInt32(userInput1);

            if(number == 0){
                break;
                }
            else{
                sum++;
                }
            }
      Console.WriteLine($"Total amount of numbers: {sum}");
    }
  }
}
