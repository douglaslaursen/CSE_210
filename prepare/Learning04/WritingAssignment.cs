class WritingAssignments : Assignment
{
    private string _title;

    public WritingAssignments(string title, string studentName, string topic)
    :base (studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{_title}";
    }
}