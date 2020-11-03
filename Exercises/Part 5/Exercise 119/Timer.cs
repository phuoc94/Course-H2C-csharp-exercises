namespace exercise_119
{
    public class Timer
    {
        public int seconds { get; set; }
        public int hundredths { get; set; }

        public Timer()
        {
            this.seconds = 0;
            this.hundredths = 0;
        }

        public void Advance()
        {
            this.hundredths++;
            if (this.hundredths >= 100)
            {
                this.hundredths = 0;
                seconds++;
            }
            if (this.seconds >= 60)
            {
                this.seconds = 0;
            }

        }

        public override string ToString()
        {
            return $"{this.seconds}:{this.hundredths}";
        }
    }
}