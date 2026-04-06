using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running running = new Running(10, "Nov 12", 120);

        Cycling cycling = new Cycling(15, "Nov 13", 180);

        Swimming swimming = new Swimming(6, "Nov 14", 60);

        List<Activity> excersize = new List<Activity>();

        excersize.Add(running);
        excersize.Add(cycling);
        excersize.Add(swimming);

        foreach (Activity activity in excersize)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}