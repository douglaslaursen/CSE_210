class Videos
{
    private List<Comments> comments;
    private string _title;
    private string _author;
    private int _length;

    public Videos(List<Comments> comments, string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = [];
    }

    public void DisplayVideos()
    {
        
    }
}