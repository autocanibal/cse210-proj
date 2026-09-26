using System;

public class Comment
{
    public string _author;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comment: {_text}");
    }
}
