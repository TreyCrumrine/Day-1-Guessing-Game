// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome everyone to Mat and Trey's Guessing Game!!");

int correctNumber = 6;


Console.WriteLine("Guess a number between 1 and 10!");
int guessNumber = Convert.ToInt32(Console.ReadLine());

if (guessNumber == correctNumber)
{
    Console.WriteLine("You guessed the secret number!");
}
else
{
    Console.WriteLine("You chose poorly");
}

