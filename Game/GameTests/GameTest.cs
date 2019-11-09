using System;
using Xunit;
using GameClasses;


namespace GameTests
{
    public class GameTest
    {
        [Fact]
        public void CreateAnInstanceOfGame()
        {
            GameClasses.Game game = new GameClasses.Game();
            Assert.IsType<GameClasses.Game>(game);
        }

   
    }
}
