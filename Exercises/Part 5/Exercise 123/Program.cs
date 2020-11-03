using System;

namespace exercise_123
{
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your code here.
            Counter counter = new Counter();

            Console.WriteLine(counter);

            counter.Increase();
            Console.WriteLine(counter);

            counter.Decrease();
            Console.WriteLine(counter);

            counter.Increase(5);
            Console.WriteLine(counter);

            counter.Increase(-5);
            Console.WriteLine(counter);

            counter.Decrease(5);
            Console.WriteLine(counter);

            counter.Decrease(-5);
            Console.WriteLine(counter);

        }
    }
}
