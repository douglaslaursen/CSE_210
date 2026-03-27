class Menu
{
    public void DisplayMainMenu()
    {
        Goals myGoals = new Goals();

        int option1 = 0;
        do
        {
            // Shows score
            Console.Clear();
            Console.WriteLine();
            myGoals.DisplayScore();
            Console.WriteLine();

            // display menu
            Console.WriteLine("Menu Options");
            Console.WriteLine("   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a Choice from the menu: ");
            option1 = int.Parse(Console.ReadLine());

            DisplayMainOption(option1, myGoals);
        } while (option1 != 6);
    }

    public void DisplayGoalMenu(Goals myGoals)
    {
        int option2 = 0;
        do
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n   4. Go back to main");
            Console.Write("Select a Choice from the menu: ");
            option2 = int.Parse(Console.ReadLine());

            DisplayGoalOptions(option2, myGoals);
        } while (option2 != 4);
    }

    public void DisplayMainOption(int option1, Goals myGoals)
    {
        if (option1 == 1)
        {
            DisplayGoalMenu(myGoals);
        }
        else if (option1 == 2)
        {
            myGoals.DisplayGoals();
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

    public void DisplayGoalOptions(int Option2, Goals myGoals)
    {
        if (Option2 == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.CreateGoal();
            myGoals.AddGoal(simpleGoal);
        }
        else if (Option2 == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.CreateGoal();
            myGoals.AddGoal(eternalGoal);
        }
        else if (Option2 == 3)
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.CreateGoal();
            myGoals.AddGoal(checklistGoal);
        }
    }
}