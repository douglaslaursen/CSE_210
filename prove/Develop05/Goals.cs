class Goals
{
    private int _totalScore;

    public Goals()
    {
        _totalScore = 0;
    }

    public void DisplayScore()
    {
        Console.Write($"You have {_totalScore} points.\n");
    }
}