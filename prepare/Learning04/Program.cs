using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(mathAssignment.GetHomework());

        Console.WriteLine();
        WritingAssignments writingAssignments = new WritingAssignments("The Causes of World War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(writingAssignments.GetWritingInformation());
        
        Console.WriteLine();

    }
}