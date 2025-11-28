using System;

namespace DiceRollGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            Game game = new Game(dice);
            game.Play();
        }
    }
}
