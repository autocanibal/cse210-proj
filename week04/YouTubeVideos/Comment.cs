using System;

public class Comment
{
    public string Author;
    public string Text;

    public void Display()
    {
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Comment: {Text}");
    }
}
