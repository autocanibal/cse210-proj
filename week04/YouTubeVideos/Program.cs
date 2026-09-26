using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.Title = "The Power of Positive Thinking";
        video1.Author = "John Deery";
        video1.Length = 300;

        Comment comment1 = new Comment();
        comment1.Author = "Alice";
        comment1.Text = "Great video!";
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2.Author = "Charlie";
        comment2.Text = "Very inspiring. Truely a work of art!";
        video1.AddComment(comment2);

        Comment comment3 = new Comment();
        comment3.Author = "Eve";
        comment3.Text = "I learned a lot from this video.";
        video1.AddComment(comment3);

        Video video2 = new Video();
        video2.Title = "The Science of Happiness";
        video2.Author = "Jane Bell";
        video2.Length = 600;

        Comment comment4 = new Comment();
        comment4.Author = "David";
        comment4.Text = "This video made me smile!";
        video2.AddComment(comment4);

        Comment comment5 = new Comment();
        comment5.Author = "Frank";
        comment5.Text = "I love the way this video explains happiness.";
        video2.AddComment(comment5);

        Comment comment6 = new Comment();
        comment6.Author = "Bob";
        comment6.Text = "Very informative.";
        

        Video video3 = new Video();
        video3.Title = "The Art of Mindfulness";
        video3.Author = "Sarah Johnson";
        video3.Length = 1450;

        Comment comment7 = new Comment();
        comment7.Author = "Grace";
        comment7.Text = "This video helped me relax and focus.";
        video3.AddComment(comment7);

        Comment comment8 = new Comment();
        comment8.Author = "Hannah";
        comment8.Text = "I love the way this video explains mindfulness.";
        video3.AddComment(comment8);

        Comment comment9 = new Comment();
        comment9.Author = "Ian";
        comment9.Text = "Very calming and peaceful.";
        video3.AddComment(comment9);
        
        video1.Display();
        video2.Display();
        video3.Display();
    }
}