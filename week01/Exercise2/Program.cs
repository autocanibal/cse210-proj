using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade as a percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        string letter;
        if(percentage >= 90){
            letter = "A";
        }
        else if(percentage >= 80)
        {
            letter = "B";
        }
        else if(percentage >= 70)
        {
            letter = "C";
        }
        else if(percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if(percentage >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course!!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the course better luck next time :(");
        }

        Console.WriteLine($"Your letter grade is {letter}");
    }
}