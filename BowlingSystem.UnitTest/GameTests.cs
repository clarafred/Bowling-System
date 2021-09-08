using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingSystem.UnitTest
{
    public class GameTests
    {
        private Game game;
        public GameTests()
        {
            List<string> names = new List<string> { "Clara", "Filip" };
            game = new Game(names);
        }
        [Fact]
        public void Roll_Strike_ChangeActivePlayer()
        {
            game.Roll(10);

            Assert.Equal("Filip", game._activePlayer.Name);
        }
        [Fact]
        public void Roll_One_NotChangeActivePlayer()
        {
            game.Roll(1);

            Assert.Equal("Clara", game._activePlayer.Name);
        }
        [Fact]
        public void Roll_TwoTimes_ChangeActivePlayer()
        {
            game.Roll(1);
            game.Roll(2);

            Assert.Equal("Filip", game._activePlayer.Name);
        }

        //[Fact]
        //public void Game_StartUpEmptyList_ThrowsArgumentNull()
        //{
        //    Assert.Throws<ArgumentNullException>(() => new List<string> { });
        //}

        //[Fact]
        //public void Game_StartUpMoreThan5InList_ThrowsArgumentOutOfRange()
        //{
        //    Assert.Throws<ArgumentOutOfRangeException>(() => new List<string> { "1", "2", "3", "4", "5" });
        //}
    }
}
