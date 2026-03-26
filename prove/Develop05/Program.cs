using System;

class Program
{
    static void Main(string[] args)
    {
        Goal myGoal = new Goal();

        myGoal.SetName();
        myGoal.SetDiscription();
        myGoal.SetPoints();
        Console.WriteLine(myGoal.GetConsoleString());
    }
}