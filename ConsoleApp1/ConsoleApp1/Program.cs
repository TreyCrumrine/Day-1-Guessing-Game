// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("\n\n=====Welcome everyone to Mat and Trey's Guessing Game!!======\n\n");

int correctNumber = 6;

int guessFlag = 0;
int numGuesses = 3;
while (guessFlag == 0 && numGuesses >= 1)
{
    Console.WriteLine("Guess a number between 1 and 10! You only have 3 chances!!!");
    int guessNumber = Convert.ToInt32(Console.ReadLine());
    int difference;

    if (guessNumber == correctNumber)
    {
        Console.WriteLine("You guessed the secret number!");
        Console.WriteLine("\n--------------VICTORY!!!--------------\n");
        guessFlag = 1;
    }
    else if (guessNumber > 10 || guessNumber < 1)
    {
        Console.WriteLine("\nYou can only use numbers between 1 and 10. Please try again.");
        numGuesses--;
        
        if (guessNumber > correctNumber)
        {
            difference = guessNumber - correctNumber;
        }
        else
        {
            difference = correctNumber - guessNumber;
        }
        Console.WriteLine("\nYou are " + difference + " numbers away from the correct answer.");
        Console.WriteLine("\nYou have " + numGuesses + " guesses left.\n");

        if (numGuesses == 0)
        {
            Console.WriteLine("You've Lost the game!!!");
        }

        Console.WriteLine("\n-------------------------\n");
    }  
    else
    {
        Console.WriteLine("\nYou chose poorly");
        numGuesses--;
        if (guessNumber > correctNumber)
        {
            difference = guessNumber - correctNumber;
        }
        else
        { 
            difference = correctNumber - guessNumber;
        }
        Console.WriteLine("\nYou are " + difference +" numbers away from the correct answer.");
        Console.WriteLine("\nYou have " + numGuesses + " guesses left.\n");

        if (numGuesses == 0)
        {
            Console.WriteLine("You've Lost the game!!!");
        }

        Console.WriteLine("\n-------------------------\n");
    }
}