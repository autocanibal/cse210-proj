using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asmnt = new("Samuel Bennett", "Multiplication");
        MathAssignment math = new("Roberto Rodriguez","Fractions","7.3","8-19");
        WritingAssignment writing = new("Mary Waters", "European History", "The Causes of World War II");

        System.Console.WriteLine(asmnt.GetSummary());
        System.Console.WriteLine();
        System.Console.WriteLine(math.GetSummary());
        System.Console.WriteLine(math.GetHomeworkList());
        System.Console.WriteLine();
        System.Console.WriteLine(writing.GetSummary());
        System.Console.WriteLine(writing.GetWritingInformation());
        
    }
}