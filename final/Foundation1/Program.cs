using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Comment vid1Comment1 = new Comment("Bob", "Loved this video");
        Comment vid1Comment2 = new Comment("", "");
        Comment vid1Comment3 = new Comment("", "");

        Comment vid2Comment1 = new Comment("", "");
        Comment vid2Comment2 = new Comment("", "");
        Comment vid2Comment3 = new Comment("", "");

        Comment vid3Comment1 = new Comment("", "");
        Comment vid3Comment2 = new Comment("", "");
        Comment vid3Comment3 = new Comment("", "");
    
        Console.WriteLine();
        Video video = new Video("My first vid", "Danny", 120);
        video.AddComment(vid1Comment1);
        video.AddComment(vid1Comment2);
        video.AddComment(vid1Comment3);
        video.DisplayVideo();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------");

        Console.WriteLine();
        Video video2 = new Video("My second vid", "Danny", 220);
        video2.AddComment(vid2Comment1);
        video2.AddComment(vid2Comment2);
        video2.AddComment(vid2Comment3);
        video2.DisplayVideo();
        Console.WriteLine();

        Console.WriteLine("-----------------------------------");

        Console.WriteLine();
        Video video3 = new Video("My third vid", "Danny", 320);
        video3.AddComment(vid3Comment1);
        video3.AddComment(vid3Comment2);
        video3.AddComment(vid3Comment3);
        video3.DisplayVideo();
        Console.WriteLine();
    }
}