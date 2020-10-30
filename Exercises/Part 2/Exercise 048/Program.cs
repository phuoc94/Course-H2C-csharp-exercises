using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers: ");
      int sum = 0;
      int numbers = 0;
      int even = 0;
      while(true){
            int number = Convert.ToInt32(Console.ReadLine());
            if(number != -1){
            sum = sum+number;
            numbers++;
                if(number % 2 == 0){
                    even++;
                    }
            }
            else{
                break;
                }
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine($"Sum: {sum}");
      Console.WriteLine($"Numbers: {numbers}");
      Console.WriteLine($"Average: {(double)sum/numbers}");
      Console.WriteLine($"Even: {even}");
      Console.WriteLine($"Odd: {numbers-even}");
    }
  }
}
