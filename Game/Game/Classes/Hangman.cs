using System;
using System.Collections.Generic;

namespace GameClasses
{
    public class Hangman
    {
        public int playerLives { get; set; }
        public string answer { get; }
        public Dictionary<char, char> guesses { get; set; }


        public Hangman()
        {
            playerLives = 5;
            answer = "answer";
            guesses = new Dictionary<char, char>();

        }
    }
}
