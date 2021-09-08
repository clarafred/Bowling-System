using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingSystem.UnitTest
{
    public class RoundTests
    {
        public readonly Round round;
        public RoundTests()
        {
            round = new Round();
        }
        [Fact]
        public void Roll_Number_ScoreSame()
        {
            round.Roll(5);

            Assert.Equal(5, round.Score);
        }
        [Fact]
        public void Roll_NegativeNumber_Score0()
        {
            round.Roll(-1);

            Assert.Equal(0, round.Score);
        }
        [Fact]
        public void Roll_Over10_Score10()
        {
            round.Roll(11);

            Assert.Equal(10, round.Score);
        }
        [Fact]
        public void Roll_AllGutter_Score0()
        {
            for (var i = 0; i < 20; i++)
                round.Roll(0);
            Assert.Equal(0, round.Score);
        }
        [Fact]
        public void Roll_AllOnes_Score20()
        {
            for (var i = 0; i < 20; i++)
                round.Roll(1);
            Assert.Equal(20, round.Score);
        }
        [Fact]
        public void Roll_Spare_ScoreSpare()
        {
            round.Roll(5);
            round.Roll(5);
            round.Roll(1);
            for (var i = 0; i < 17; i++)
                round.Roll(0);
            Assert.Equal(12, round.Score);
        }
        [Fact]
        public void Roll_Strike_ScoreSpare()
        {
            round.Roll(10);
            round.Roll(1);
            round.Roll(2);
            for (var i = 0; i < 16; i++)
                round.Roll(0);
            Assert.Equal(16, round.Score);
        }
        [Fact]
        public void Roll_AllStrikes_ScoreSpare()
        {
            for (var i = 0; i < 12; i++)
                round.Roll(10);
            Assert.Equal(300, round.Score);
        }

        //[Fact]
        //public void Roll_TwoRolls_Max10()
        //{
        //    round.Roll(5);
        //    round.Roll(6);

        //    Assert.Equal(10, round.Score);
        //}
    }
}