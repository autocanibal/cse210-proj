using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "The Power of Positive Thinking";
        video1._author = "John Deery";
        video1._length = 300;

        Comment comment1 = new Comment();
        comment1._author = "Alice";
        comment1._text = "Great video!";
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2._author = "Charlie";
        comment2._text = "Very inspiring. Truely a work of art!";
        video1.AddComment(comment2);

        Comment comment3 = new Comment();
        comment3._author = "Eve";
        comment3._text = "I learned a lot from this video.";
        video1.AddComment(comment3);

        Video video2 = new Video();
        video2._title = "The Science of Happiness";
        video2._author = "Jane Bell";
        video2._length = 600;

        Comment comment4 = new Comment();
        comment4._author = "David";
        comment4._text = "This video made me smile!";
        video2.AddComment(comment4);

        Comment comment5 = new Comment();
        comment5._author = "Frank";
        comment5._text = "I love the way this video explains happiness.";
        video2.AddComment(comment5);

        Comment comment6 = new Comment();
        comment6._author = "Bob";
        comment6._text = "Very informative.";
        

        Video video3 = new Video();
        video3._title = "The Art of Mindfulness";
        video3._author = "Sarah Johnson";
        video3._length = 1450;

        Comment comment7 = new Comment();
        comment7._author = "Grace";
        comment7._text = "This video helped me relax and focus.";
        video3.AddComment(comment7);

        Comment comment8 = new Comment();
        comment8._author = "Hannah";
        comment8._text = "I love the way this video explains mindfulness.";
        video3.AddComment(comment8);

        Comment comment9 = new Comment();
        comment9._author = "Ian";
        comment9._text = "Very calming and peaceful.";
        video3.AddComment(comment9);
        
        video1.Display();
        video2.Display();
        video3.Display();
    }
}