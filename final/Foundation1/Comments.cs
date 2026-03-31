class Comments
{
    private string _commenterName;
    private string _comment;

    public Comments(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    public string GetDisplayString()
    {
        return $"{_commenterName}: {_comment}";
    }
}