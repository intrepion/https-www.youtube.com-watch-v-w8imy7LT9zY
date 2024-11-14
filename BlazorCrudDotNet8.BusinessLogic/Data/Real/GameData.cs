using System.Globalization;
using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.Maps;
using CsvHelper;

namespace BlazorCrudDotNet8.BusinessLogic.Data.Real;

public static class GameData
{
    public static async Task SeedAsync(ApplicationDbContext applicationDbContext, ApplicationUser adminUser)
    {
        if (applicationDbContext.Games is null)
        {
            return;
        }

        var fileName = @"..\..\..\..\.data\Games.csv";
        var baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        var csvFilePath = Path.Combine(baseDirectoryPath, fileName);
        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<GameMap>();

        var records = csv.GetRecords<Game>().ToList();

        foreach (var record in records)
        {
            record.ApplicationUserUpdatedBy = adminUser;
        }

        applicationDbContext.Games.AddRange(records);
        await applicationDbContext.SaveChangesAsync();
    }
}
