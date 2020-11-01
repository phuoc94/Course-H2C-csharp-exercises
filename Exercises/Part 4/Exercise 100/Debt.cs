using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace exercise_100
{
    public class Debt
    {
        private double balance;
        private double interestRate;
        public Debt(double balance, double interestRate)
        {
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }
        public void WaitOneYear()
        {
            balance = balance * interestRate;
        }
    }
}