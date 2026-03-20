using System.Runtime.InteropServices;

class Menu
{
    public void DisplayMenu()
    {
        int option = 0;
        do{
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start Listing activity\n   4. Quit");
            Console.Write("Select a Choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            DisplayOption(option);
        } while(option != 4);
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
            
        }
        else if (option == 3)
        {
            
        }
        else if (option == 4)
        {
            Console.WriteLine("Thank you");
        }
    }


}