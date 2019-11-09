using System;
namespace GameClasses
{
    public class Hangman
    {
        public int playerLives { get; set; }
        public string answer { get; }


        public Hangman()
        {
            playerLives = 5;
            answer = "answer";

        }
    }
}
