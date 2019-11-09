using System;
using Xunit;

namespace GameTests
{
    public class HangmanTest
    {
        [Fact]
        public void InstatiateHangmanInstantiationTest()
        {
            GameClasses.Hangman hangman = new GameClasses.Hangman();
            Assert.IsType<GameClasses.Hangman>(hangman);
        }
    }
}
