using BlazorCrudDotNet8.BusinessLogic.Entities;
using Bogus;

namespace BlazorCrudDotNet8.BusinessLogic.Data;

public static class TestData
{
    public static async Task SeedAsync(ApplicationDbContext applicationDbContext)
    {
        Randomizer.Seed = new Random(8675309);

        var games = new Faker<Game>()
            .RuleFor(x => x.Name, faker => faker.Company.CompanyName())
        ;
        var gameRecords = games.Generate(16);

        // FakeEntityPlaceholder

        applicationDbContext.Games.AddRange(gameRecords);

        await applicationDbContext.SaveChangesAsync();
    }
}
