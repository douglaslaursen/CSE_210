class BreathingActivity : Activity
{
    private int _breathInTime;
    private int _breathOutTime;

    public BreathingActivity(int breathInTime, int breathOutTime)
    : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ")
    {
        _breathInTime = breathInTime;
        _breathOutTime = breathOutTime;
    }

    public void RunBreathingActivity()
    {
        IntroActivity();
        
        BreathingCycle();

        Console.WriteLine();
        DisplayEnding();
        DisplaySpinner("", 5);
    }

    private void BreathingCycle()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            RunCountDown("Breath in... ", _breathInTime);
            Console.WriteLine();
            RunCountDown("Breath out... ", _breathOutTime);
            Console.WriteLine();

        }
    }
}