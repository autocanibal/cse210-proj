using System;

public class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            comment.Display();
            Console.WriteLine();
        }
    }
}
