using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("Breathing", 
            "This activity will help you breath better.");

        activity.DisplayGreeting();
        activity.DisplayDescription();

        activity.DisplaySpinner("Hello There", 25);
    }
}