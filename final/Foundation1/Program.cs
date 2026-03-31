using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Comments comments = new Comments("Bob", "Loved this video");
        Console.WriteLine(comments.GetDisplayString());
    }
}