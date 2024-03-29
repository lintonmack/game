﻿using System;
using System.Collections.Generic;
using Xunit;

namespace GameTests
{
    public class HangmanTest
    {
        // A game is started
        // A user chooses a letter at random
        // the users choice of letters should be logged
        // the users lives shoud be tracked
        // the user should be shown the correct guesses
        // until the word is guessed or the user runs out of lives

        [Fact]
        public void InstatiateHangmanInstantiationTest()
        {
            GameClasses.Hangman hangman = new GameClasses.Hangman();
            Assert.IsType<GameClasses.Hangman>(hangman);
        }

        [Fact]
        public void CheckTheUsersLivesStartAtFive()
        {
            GameClasses.Hangman hangman = new GameClasses.Hangman();
            Assert.Equal(hangman.playerLives, 5);
        }

        [Fact]
        public void CheckWhenTheGameStartsThereIsAnAnswer()
        {
            GameClasses.Hangman hangman = new GameClasses.Hangman();
            Assert.IsType<string>(hangman.answer);
            Assert.NotNull(hangman.answer);
            Assert.NotEqual(hangman.answer, "");
        }

        [Fact]
        public void CheckWhenTheGameStartsAnEmptyGuessesDictionaryIsCreated()
        {
            GameClasses.Hangman hangman = new GameClasses.Hangman();
            Assert.IsType<Dictionary<char, char>>(hangman.guesses);
            Assert.Empty(hangman.guesses);
        }


    }
}
