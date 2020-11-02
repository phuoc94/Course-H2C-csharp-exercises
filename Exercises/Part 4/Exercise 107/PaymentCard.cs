namespace exercise_107
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
            this.balance -= 10.6;
        }
        public void DrinkCoffee()
        {
            this.balance -= 2.0;
        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}