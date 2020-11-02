using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
            while(true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();

                if(userInput == "end"){
                    break;
                }else{
                    int number = Convert.ToInt32(userInput);
                    Console.WriteLine(number*number*number);
                }
            }

    }
  }
}
