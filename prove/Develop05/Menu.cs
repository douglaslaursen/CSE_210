class Menu
{
    public void DisplayMainMenu()
    {
        int option1 = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a Choice from the menu: ");
            option1 = int.Parse(Console.ReadLine());

            DisplayMainOption(option1);
        } while (option1 != 6);
    }

    public void DisplayGoalMenu()
    {
        int option2 = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n   4. Go back to main");
            Console.Write("Select a Choice from the menu: ");
            option2 = int.Parse(Console.ReadLine());

            DisplayGoalOptions(option2);
        } while (option2 != 4);
    }

    public void DisplayMainOption(int option1)
    {
        if (option1 == 1)
        {
            DisplayGoalMenu();
        }
        else if (option1 == 2)
        {
            
        }
        else if (option1 == 3)
        {
            
        }
        else if (option1 == 4)
        {
            Console.WriteLine("Thank you");
        }
        else if (option1 == 5)
        {
            Console.WriteLine("Thank you");
        }
        else if (option1 == 6)
        {
            Console.WriteLine("Thank you");
        }
    }

    public void DisplayGoalOptions(int Option2)
    {
        if (Option2 == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.CreateGoal();
        }
        else if (Option2 == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.CreateGoal();
        }
        else if (Option2 == 3)
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.CreateGoal();
        }
    }
}