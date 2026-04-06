using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running running = new Running(10, "Nov 12", 120);
        running.GetRunningSummary();

        Cycling cycling = new Cycling(15, "Nov 13", 180);
        cycling.GetCyclingSummary();

        
    }
}