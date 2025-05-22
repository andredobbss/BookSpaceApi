using BookSpaceApi.Entities;

namespace BookSpaceApi.Data;


public class Query
{
   

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Author> GetAuthors([Service] AppDbContext context) => context.Authors;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Publisher> GetPublishers([Service] AppDbContext context) => context.Publishers;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Book> GetBooks([Service] AppDbContext context) => context.Books;
}
