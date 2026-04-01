class Video
{
    private List<Comment> _comments;
    private string _title;
    private string _author;
    private int _length;

    public Video( string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video: {_title}\nChannel: {_author}\nLength (Seconds): {_length}");

        Console.WriteLine();
        Console.WriteLine("Comments:");

        int count = 1;
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{count++}. {comment.GetDisplayComments()}");
        }
        
    }
}