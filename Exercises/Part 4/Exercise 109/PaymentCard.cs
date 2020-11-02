using System.Threading;

namespace exercise_109
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }
        public void EatLunch()
        {
            if (this.balance > 10.6)
            {
                this.balance -= 10.6;
            }
        }
        public void DrinkCoffee()
        {
            if (this.balance > 2)
            {
                this.balance -= 2.0;
            }
        }

        public void AddMoney(double amount)
        {
            // write code here
            if (amount > 0)
            {
                if (this.balance + amount <= 150)
                {
                    this.balance += amount;
                }
                else
                {
                    this.balance = 150;
                }
            }
        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}