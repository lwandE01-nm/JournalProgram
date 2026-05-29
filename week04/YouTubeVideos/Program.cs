using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Learning C# Basics";
        video1._author = "John Smith";
        video1._length = 300;

        video1._comments.Add(new Comment("Alice", "Great tutorial!"));
        video1._comments.Add(new Comment("Mike", "Very helpful."));
        video1._comments.Add(new Comment("Sarah", "Thanks for explaining clearly."));

        Video video2 = new Video();
        video2._title = "Cooking Pasta";
        video2._author = "Chef Maria";
        video2._length = 450;

        video2._comments.Add(new Comment("Tom", "Looks delicious!"));
        video2._comments.Add(new Comment("Jane", "I will try this recipe."));
        video2._comments.Add(new Comment("Chris", "Amazing cooking tips."));

        Video video3 = new Video();
        video3._title = "Morning Workout";
        video3._author = "Fitness Pro";
        video3._length = 600;

        video3._comments.Add(new Comment("Lily", "Awesome workout!"));
        video3._comments.Add(new Comment("Ben", "I feel energized."));
        video3._comments.Add(new Comment("Emma", "Loved this session."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}
