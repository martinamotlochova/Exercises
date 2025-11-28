using System;

namespace DiceRollGame;

public class Game
{
    private Dice dice;
    private int maxAttempts;

    public Game(Dice dice, int maxAttempts = 3)
    {
        this.dice = dice;
        this.maxAttempts = maxAttempts;
    }

    public void Play()
    {
        int numberrolled = dice.Roll();
        int guess;

        Console.WriteLine($"Dice rolled. Guess what number it shows in {maxAttempts} tries.");


        for (int i = 1; i <= 3; i++)
            {
                do
                {
                    Console.WriteLine("Enter a number: ");

                } while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 6);

                if(guess == numberrolled)
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
