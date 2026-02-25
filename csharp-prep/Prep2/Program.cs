using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        int grade;

        Console.Write("What is your grade percentage? ");
        // string resopone = Console.ReadLine();
        // grade = int.Parse(resopone);

        grade = int.Parse(Console.ReadLine());

        if (grade >= 70)
        {
            Console.WriteLine($"With a grade of {grade}. You Passed");
        }
        else
        {
            Console.WriteLine($"With a grade of {grade}. You Failed");
        }

        if (grade >= 90)   // Don't put ; or it ends the if statement
        {
            Console.WriteLine("You got an A!");  // If code block is just one line we don't need {} Good pratice to have them if You need to add more code to it
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You have failed! F");
        }

    }
}