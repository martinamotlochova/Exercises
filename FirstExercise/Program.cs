using System;

namespace DiceRollGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dice dice = new Dice();
            int numberrolled = dice.Roll();
            int number;
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries. ");

            for (int i = 1; i <= 3; i++)
            {
                do
                {
                    Console.WriteLine("Enter a number: ");

                } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 6);

                if(number == numberrolled)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong guess");
                }
                if(i == 3)
                {
                    Console.WriteLine("You lose. No more attempts!");
                }
            }



        }
    }
}
