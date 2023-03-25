using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of videos
            List<Video> videos = new List<Video>();

            // Create Video objects and add them to the list
            Video video1 = new Video();
            video1._title = "First Video";
            video1._author = "Connor Ebanks";
            video1._length = 49;
            video1.Comments.Add(new Comment("Eric West", "Awesome video!"));
            video1.Comments.Add(new Comment("Harold Kent", "What a cool video!"));
            videos.Add(video1);

            Video video2 = new Video();
            video2._title = "Second video";
            video2._author = "John Johnson";
            video2._length = 61;
            video2.Comments.Add(new Comment("Conor McGregor", "What an awesome video!"));
            video2.Comments.Add(new Comment("Shaq Diesel", "This is the best video!"));
            videos.Add(video2);

            Video video3 = new Video();
            video3._title = "Third video";
            video3._author = "Chuck Barkley";
            video3._length = 159;
            video3.Comments.Add(new Comment("Kevin Durant", "I love basketball!"));
            video3.Comments.Add(new Comment("Kevin Garnett", "Basketball is the best!"));
            videos.Add(video3);

            Video video4 = new Video();
            video4._title = "Fourth video";
            video4._author = "Ja Morant";
            video4._length = 291;
            video4.Comments.Add(new Comment("Shane Battier", "I am in the NBA!"));
            video4.Comments.Add(new Comment("Ray Allen", "Three point specialist!"));
            videos.Add(video4);

            // Iterate through the list of videos and display the title, author, length, and number of comments
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video._title}");
                Console.WriteLine($"Author: {video._author}");
                Console.WriteLine($"Length: {video._length} seconds");
                Console.WriteLine($"Number of comments: {video.Comments.Count}");

                // List out all of the comments for that video
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"Commenter: {comment._name}");
                    Console.WriteLine($"Comment: {comment._text}");
                }
                Console.WriteLine();
            }
        }
    }