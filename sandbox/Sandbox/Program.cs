using System;
using System.Runtime.CompilerServices;

class Program
{
    // // ---------------------------- functions!!!!!! -----------------------------------------------
    // public static void greeting() 
    // {
    //     Console.WriteLine("Hello Bob");
    // }

    // public static int AddNumbers(int n1, int n2) // int is showing I am returning something! Retrun ends the statement! 
    // {
    //     Console.WriteLine("Bob");
    //     return n1 + n2;
    // }

    static void Main(string[] args)
    {

        // int x = 20;
        Console.WriteLine("Circle");

        Circle myCircle = new Circle();

        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetRadius());
        myCircle._radius = 900;

        Console.WriteLine("Circle 2");

        Circle myCircle2 = new Circle();

        myCircle2.SetRadius(99999999);
        Console.WriteLine(myCircle2.GetRadius());

        Console.WriteLine(myCircle2.GetArea());
        Console.WriteLine(myCircle2.GetCircumference());


    //     // Calling the function
    //     greeting(); 

    //     int total = AddNumbers(10, 20);
    //     Console.WriteLine(total);
        // -------------------------------------------------- For loops -----------------------------------------------------------------
        // for (int i = 0; i < 10; i += 3) // i++ to make it just add 1
        // {
        //     Console.WriteLine(i);
        // }

        // int y = 10;
        // int z = y++;
        // Console.WriteLine(y); // incrament y then add one with ++y with ++y 
        // Console.WriteLine(z);

        // for (int i = 100000; i >= -100000; i -= 10000)
        // {
        //     Console.WriteLine(i);
        // }

        // --------------------------------------------------- While Loops ---------------------------------------------------------------
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Please input your age: ");
        //     int age = int. Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank you");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // }


        // bool done;
        // do
        // {
        //     Console.Write("Please input your age: ");
        //     int age = int. Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine("Thank you");
        //     }
        //     else
        //     {
        //         done = false;
        //         Console.WriteLine("Please input a valid age.");
        //     }
        // } while (! done);


        //--------------------------------------------------- Lists ---------------------------------------------------------------
        // List<int> myData = new List<int>();
        // myData.Add(10);
        // myData.Add(11);
        // myData.Add(12);
        // myData.Add(13);
        // myData.Add(14);
        // myData.Add(15);

        // Console.WriteLine(myData.Count); // # of items in my list

        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);
        // }

        // List<string> myFriends = ["Bob", "Betty", "Jennie"];
        // myFriends.Add("Bubba");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }

    }
    // public static void passByValue(int a)
    //     {
    //         a++;
    //         Console.WriteLine($"In the value function: {a}");
    //     }

    // public static void passByRef(ref int x)
    // {
    //     x++;
    //     Console.WriteLine($"In the ref function: {x}");
    // }

    // public static void passByOut(out int y)  // Input from the user
    // {
    //     y = 10;
    // }

    // static void Main(string[] args)
    //     {
    //         int x = 20;
    //         Console.WriteLine($"In the main 1: {x}");

    //         passByValue(x);
    //         Console.WriteLine($"In the main 2: {x}");
    //         passByRef(ref x);
    //         Console.WriteLine($"In the main 3: {x}");

    //         int z;
    //         passByOut(out z);  //Data types must match! 
    //         Console.WriteLine(z);
    // }
}