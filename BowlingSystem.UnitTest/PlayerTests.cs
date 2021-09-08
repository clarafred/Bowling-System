using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingSystem.UnitTest
{
    public class PlayerTests
    {
        [Fact]
        public void CreateInstance_NewPlayer_Name()
        {
            var player = new Player("Clara");

            Assert.Equal("Clara", player.Name);
        }

        [Fact]
        public void CreateInstance_NewPlayer_Score0()
        {
            var player = new Player("Clara");

            Assert.Equal(0, player.Round.Score);
        }
    }
}
