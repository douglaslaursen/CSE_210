using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();

        Activity activity = new Activity("Breathing", 
            "This activity will help you breath better.");

        activity.DisplayGreeting();
        activity.DisplayDescription();

        activity.DisplaySpinner("Hello There", 5);

        Console.WriteLine();
        activity.RunCountDown("Hi", 6);
    }
}