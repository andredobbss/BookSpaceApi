using BookSpaceApi.Entities.Base;

namespace BookSpaceApi.Entities;

public class Book : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Pages { get; set; }
    public Guid AuthorId { get; set; }
    public Guid PublisherId { get; set; }

    public Author? Author { get; set; }
    public Publisher? Publisher { get; set; }
}

