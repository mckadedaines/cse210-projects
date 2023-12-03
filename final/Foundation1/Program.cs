using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create and add comments to the first video
        var video1 = new Video("How to Program in C#", "CoderJoe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Looking forward to more content!"));

        // Create and add comments to the second video
        var video2 = new Video("C# for Beginners", "DevSally", 600);
        video2.AddComment(new Comment("Dave", "Nice explanation."));
        video2.AddComment(new Comment("Eve", "This was easy to follow."));
        video2.AddComment(new Comment("Frank", "Can you cover more advanced topics?"));

        // Add videos to a list
        var videos = new List<IVideo> { video1, video2 };

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}\n");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
