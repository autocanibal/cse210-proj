using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        System.Console.Write("Please enter your name: ");
        string name = PromptUserName(Console.ReadLine());
        System.Console.Write("Please enter your favourite number: ");
        int number = SquareNumber(PromptUserNumber(int.Parse(Console.ReadLine())));
        DisplayResult(name, number);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(string userName)
    {
        return userName;
    }

    static int PromptUserNumber(int number)
    {
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squarenumber)
    {
        System.Console.WriteLine($"{name}, the square of your number is {squarenumber}");
    }
}