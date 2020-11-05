using System;
using System.Collections.Generic;

namespace exercise_135
{
    public class JokeManager
    {
        List<string> jokes;
        Random rnd;
        public JokeManager()
        {
            this.jokes = new List<string>();
            rnd = new Random();
        }

        public void AddJoke(string joke)
        {
            jokes.Add(joke);
        }
        public string DrawJoke()
        {
            return jokes[rnd.Next(jokes.Count)];
        }
        public void PrintJokes()
        {
            foreach (string joke in jokes)
            {
                Console.WriteLine(joke);
            }
        }
    }
}