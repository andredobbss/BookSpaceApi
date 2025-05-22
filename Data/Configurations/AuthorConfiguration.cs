using Bogus;
using BookSpaceApi.Entities;

namespace BookSpaceApi.Data.Configurations;

public static class AuthorConfiguration
{
    public static IEnumerable<Author> GetFakerAuthor()
    {
        var faker = new Faker<Author>().StrictMode(true)
            .RuleFor(a => a.Id, f => Guid.NewGuid())
            .RuleFor(a => a.Name, f => f.Name.FirstName())
            .RuleFor(a => a.BirthDate, f => f.Date.Recent(50))
            .Ignore(a => a.Books);
        return faker.Generate(10);
    }
}
