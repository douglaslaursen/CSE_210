using System.Globalization;

class MathAssignment : Assignment
{
    private string _texbookSection;
    private string _problems;

    public MathAssignment(string texbookSection, string problems, string studentName, string topic)
    :base (studentName, topic)
    {
        _texbookSection = texbookSection;
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"{GetSummary()}\n{_texbookSection} {_problems}";
    }

}