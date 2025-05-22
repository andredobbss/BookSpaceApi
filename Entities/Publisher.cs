using BookSpaceApi.Entities.Base;

namespace BookSpaceApi.Entities;

public class Publisher : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    [UseSorting]
    public ICollection<Book> Books { get; set; } = [];
}
