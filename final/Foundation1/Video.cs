using System.Collections.Generic;

public class Video : IVideo
{
    private readonly List<IComment> _comments = new List<IComment>();

    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public IReadOnlyList<IComment> Comments => _comments.AsReadOnly();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(IComment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }
}
