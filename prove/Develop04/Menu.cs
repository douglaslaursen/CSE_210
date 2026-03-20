using System.Runtime.InteropServices;

class Menu
{
    public void DisplayMenu()
    {
        int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start Listing activity\n   4. Quit");
            Console.Write("Select a Choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            DisplayOption(option);
        } while (option != 4);
    }

    public void DisplayOption(int option)
    {
        if (option == 1)
        {
            BreathingActivity breathingActivity = new BreathingActivity(3, 6);
            breathingActivity.RunBreathingActivity();
        }
        else if (option == 2)
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity(["Think of a time when you stood up for someone else. ", "Think of a time when you did something really difficult. ", "Think of a time when you helped someone in need. ", "Think of a time when you did something truly selfless. "], ["Why was this experience meaningful to you? ", "Have you ever done anything like this before? ", "How did you get started? ", "How did you feel when it was complete? ", "What made this time different than other times when you were not as successful? ", "What is your favorite thing about this experience? ", "What could you learn from this experience that applies to other situations? ", "What did you learn about yourself through this experience? ", "How can you keep this experience in mind in the future? "]);
            reflectionActivity.RunReflectionActivity();
        }
        else if (option == 3)
        {
            ListingActivity listingActivity = new ListingActivity(["Who are people that you appreciate? ", "What are personal strengths of yours? ", "Who are people that you have helped this week? ", "When have you felt the Holy Ghost this month? ", "Who are some of your personal heroes? "], []);
            listingActivity.RunListingActivity();
        }
        else if (option == 4)
        {
            Console.WriteLine("Thank you");
        }
    }


}