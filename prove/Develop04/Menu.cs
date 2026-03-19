using System.Runtime.InteropServices;

class Menu
{
    private int _option;

    // public Menu(int option)
    // {
    //     _option = option;
    // }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start Listing activity\n   4. Quit");
        Console.Write("Select a Choice from the menu: ");
        int option = int.Parse(Console.ReadLine());
    }

    // public void DisplayOption()
    // {
    //     if (_option == 1)
    //     {
            
    //     }
    //     else if (_option == 2)
    //     {
            
    //     }
    //     else if (_option == 3)
    //     {
            
    //     }
    //     else if (_option == 4)
    //     {
            
    //     }
    // }


}