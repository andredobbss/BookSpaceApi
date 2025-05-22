using Bogus;
using BookSpaceApi.Entities;
using CountryData.Bogus;

namespace BookSpaceApi.Data.Configurations;

public static class PublisherConfiguration
{
    public static IEnumerable<Publisher> GetFakerPublisher()
    {
        var faker = new Faker<Publisher>().StrictMode(true)
             .RuleFor(p => p.Id, f => Guid.NewGuid())
             .RuleFor(p => p.Name, f => f.Company.CompanyName())
             .RuleFor(p => p.Country, f => f.Country().Name())
             .Ignore(p => p.Books);
        return faker.Generate(5);
    }
}
