using BookSpaceApi.Entities.Base;

namespace BookSpaceApi.Entities;

public class Author : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }

    [UseSorting]
    public ICollection<Book> Books { get; set; } = [];
}
