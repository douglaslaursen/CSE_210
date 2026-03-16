using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
    }
}