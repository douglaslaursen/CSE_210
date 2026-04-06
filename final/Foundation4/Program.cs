using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running running = new Running(10, "Nov 12", 120);
        Console.WriteLine(running.GetSummary());

        Cycling cycling = new Cycling(15, "Nov 13", 180);
        Console.WriteLine(cycling.GetSummary());

        Swimming swimming = new Swimming(6, "Nov 14", 60);
        Console.WriteLine(swimming.GetSummary());

    }
}