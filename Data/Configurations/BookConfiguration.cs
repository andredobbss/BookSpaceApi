using Bogus;
using BookSpaceApi.Entities;

namespace BookSpaceApi.Data.Configurations;

public static class BookConfiguration
{
    public static IEnumerable<Book> GetFakerBook()
    {
        var faker = new Faker<Book>()
        .RuleFor(b => b.Id, f => Guid.NewGuid())
        .RuleFor(b => b.Title, f => f.Lorem.Sentence(3))
        .RuleFor(b => b.Year, f => f.Date.Past(20).Year)
        .RuleFor(b => b.Pages, f => f.Random.Int(100, 1000))
        .RuleFor(b => b.AuthorId, f => f.PickRandom(AuthorConfiguration.GetFakerAuthor().Select(a => a.Id)))
        .RuleFor(b => b.PublisherId, f => f.PickRandom(PublisherConfiguration.GetFakerPublisher().Select(p => p.Id)));
        return faker.Generate(15);
    }
}
