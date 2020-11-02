using System;
using System.Security.AccessControl;

namespace exercise_104
{
    public class Multiplier
    {
        private int number;
        private int instance;
        public Multiplier(int number)
        {
            this.number = number;
            this.instance = number;
        }
        public int Multiply(int number)
        {

            int result = this.instance * number;
            this.instance = result;
            return result;
        }
    }
}