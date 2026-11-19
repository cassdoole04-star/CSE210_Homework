using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // Create first video and add comments
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        videos.Add(video1);

        // Create second video and add comments
        Video video2 = new Video("Learn Python", "Jane Smith", 900);
        video2.AddComment(new Comment("Charlie", "This was very informative."));
        video2.AddComment(new Comment("Dave", "I learned a lot from this."));
        videos.Add(video2);

        // Create third video and add comments
        Video video3 = new Video("Java Basics", "Emily Johnson", 750);
        video3.AddComment(new Comment("Frank", "Excellent explanation of concepts."));
        video3.AddComment(new Comment("Grace", "I appreciate the clear examples."));
        videos.Add(video3);

        // Display information about each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}