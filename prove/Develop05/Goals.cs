using System.IO.Enumeration;

class Goals
{
    private int _totalScore;
    private List<Goal> _goals;

    public Goals()
    {
        _totalScore = 0;
        _goals = [];
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.Write($"You have {_totalScore} points.\n");
    }

    private string ObtainFileName()
    {
        string filename;
        Console.WriteLine("Please enter the file name: ");
        filename = Console.ReadLine();
        return filename;
    }

    public void LoadGoals()
    {
        string filename = ObtainFileName();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('#');
            string lineType = parts[0];

            if (lineType == "Score")
            {
                _totalScore = int.Parse(parts[1]);
                
            }
            else
            {
                string name = parts[1];
                string discription = parts[2];
                int numberOfPoints = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                if (lineType == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, discription, numberOfPoints, status, lineType);
                    _goals.Add(simpleGoal);
                }
                else if (lineType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, discription, numberOfPoints, status, lineType, 0);
                    _goals.Add(eternalGoal);
                }   
                else if (lineType == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, discription, numberOfPoints, status, lineType,0,0,0);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }

    public void SaveGoals()
    {
        string filename = ObtainFileName();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score#{_totalScore}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
    }

    public void DisplayGoals()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count++}. {goal.GetConsoleString()}");
        }

        Console.Write("Press Enter to Continue");
        Console.ReadLine();

    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("For jalsd;f");
        int choice = int.Parse(Console.ReadLine());

        _totalScore += _goals[choice -1].RecordEvent();
    }

}