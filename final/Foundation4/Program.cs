using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Running running = new Running(10, "Nov 12", 120);

        Cycling cycling = new Cycling(15, "Nov 13", 180);

        Swimming swimming = new Swimming(6, "Nov 14", 60);

        List<Activity> exercise = new List<Activity>();

        exercise.Add(running);
        exercise.Add(cycling);
        exercise.Add(swimming);

        foreach (Activity activity in exercise)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
        }
    }
}