using System;

namespace exercise_94
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account HeikkiAcc = new Account("Heikki's account", 1000.0);
            Account PersonalAcc = new Account("Personal account", 0);
            HeikkiAcc.Withdrawal(100);
            PersonalAcc.Deposit(100);
            Console.WriteLine(HeikkiAcc);
            Console.WriteLine(PersonalAcc);

        }
    }
}



