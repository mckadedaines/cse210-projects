using System.Collections.Generic;

public interface IVideo
{
    string Title { get; }
    string Author { get; }
    int Length { get; }
    IReadOnlyList<IComment> Comments { get; }

    void AddComment(IComment comment);
    int NumberOfComments();
}
