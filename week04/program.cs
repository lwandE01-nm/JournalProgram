using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Classes Tutorial", "Tech Guru", 600);
        Video video2 = new Video("Learn Abstraction", "Code Master", 750);
        Video video3 = new Video("OOP Basics Explained", "Dev Simplified", 500);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("John", "I finally understand classes."));
        video1.AddComment(new Comment("Mary", "Great explanation."));

        // Add comments to video 2
        video2.AddComment(new Comment("Sam", "Abstraction is clearer now."));
        video2.AddComment(new Comment("Lebo", "Nice examples!"));
        video2.AddComment(new Comment("Tom", "This helped a lot."));

        // Add comments to video 3
        video3.AddComment(new Comment("Zoe", "Perfect introduction."));
        video3.AddComment(new Comment("Mike", "Simple and clear."));
        video3.AddComment(new Comment("Nelly", "I understand OOP now."));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display results
        foreach (Video video in videos)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("---- Comments ----");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}