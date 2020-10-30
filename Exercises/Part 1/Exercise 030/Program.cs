using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userInput1 = Console.ReadLine();
      int Percent = Convert.ToInt32(userInput1);


    if (Percent < 0){
            Console.WriteLine("Impossible");
            }
    else if (Percent <= 49){
            Console.WriteLine("Fail");
            }
    else if (Percent <= 59){
            Console.WriteLine("1");
            }
    else if (Percent <= 69){
            Console.WriteLine("2");
            }
    else if (Percent <= 79){
            Console.WriteLine("3");
            }
    else if (Percent <= 89){
            Console.WriteLine("4");
            }
    else if (Percent <= 100){
            Console.WriteLine("5");
            }
    else{
            Console.WriteLine("Outstanding!");
            }
    }
  }
}
