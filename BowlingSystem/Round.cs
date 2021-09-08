using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingSystem
{
    public class Round
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;
        public int Score
        {
            get
            {
                var score = 0;
                var rollIndex = 0;
                for (var frame = 0; frame < 10; frame++)
                {
                    if (_rolls[rollIndex] == 10)
                    {
                        score += _rolls[rollIndex] + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                        rollIndex++;
                    }
                    else if (_rolls[rollIndex] + _rolls[rollIndex + 1] == 10)
                    {
                        score += _rolls[rollIndex] + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                        rollIndex += 2;
                    }
                    else
                    {
                        score += _rolls[rollIndex] + _rolls[rollIndex + 1];
                        rollIndex += 2;
                    }
                }
                return score;
            }
        }
        public void Roll(int pins)
        {
            if (pins < 0)
                _rolls[_currentRoll++] = 0;
            else if (pins > 10)
                _rolls[_currentRoll++] = 10;
            else
            _rolls[_currentRoll++] = pins;
        }
    }
}
