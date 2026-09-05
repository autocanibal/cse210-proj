using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest_number = new int();
        while (true)
        {
            System.Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if(number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
                sum += number;
                if(number > largest_number)
                {
                    largest_number = number;
                }
            }
            
        }
        
        System.Console.WriteLine($"The sum is: {sum}");
        System.Console.WriteLine($"The average is: {sum/numbers.Count}");
        System.Console.WriteLine($"The largest number is: {largest_number}");
    }
}