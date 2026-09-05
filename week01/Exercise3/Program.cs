using System;

class Program
{
    static void Main(string[] args)
    {
        Random rNG = new Random();
        int number = rNG.Next(1,101);
        int guesses = 0;
        while(true)
        {
            Console.Write("What is your guess? ");
            int guessedNumber = int.Parse(Console.ReadLine());
            
            if(guessedNumber > number)
            {
                System.Console.WriteLine("Lower");
                guesses +=1;
            }
            else if(guessedNumber < number)
            {
                System.Console.WriteLine("Higher");
                guesses +=1;
            }
            else
            {
                break;
            }
        }
        System.Console.WriteLine($"You guessed it!! \nIt took {guesses} guesses");

    }
}