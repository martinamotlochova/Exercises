using System;

namespace DiceRollGame
{
    public class Dice
    {
        private Random random = new Random();

        public int Roll(int min = 1, int max = 7)
        {
            return random.Next(min, max);
        }
    }
}