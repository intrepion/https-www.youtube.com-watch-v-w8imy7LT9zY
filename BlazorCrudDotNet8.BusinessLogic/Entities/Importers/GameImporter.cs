using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using ApplicationNamePlaceholder.BusinessLogic.Data;
using ApplicationNamePlaceholder.BusinessLogic.Entities.Records;
using Microsoft.EntityFrameworkCore;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Importers;

public static class GameImporter
{
    public static async Task ImportAsync(
       ApplicationDbContext context,
       string userName, string csvPath
    )
    {
        if (!File.Exists(csvPath))
        {
            Console.WriteLine("File not found: " + csvPath);
            return;
        }

        if (context.Games is null)
        {
            Console.WriteLine("Database table not found: context.Games");
            return;
        }

        var normalizedUserName = userName.ToUpperInvariant();
        var applicationUserUpdatedBy = await context.Users.SingleOrDefaultAsync(x => x.NormalizedUserName != null && x.NormalizedUserName.Equals(normalizedUserName));

        if (applicationUserUpdatedBy is null)
        {
            Console.WriteLine("UserName not found: " + userName);
            return;
        }

        using var reader = new StreamReader(csvPath);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = x => x.Header.ToUpper(CultureInfo.InvariantCulture),
            Delimiter = "|",
        });

        var records = csv.GetRecords<GameRecord>();

        // EntityListCodePlaceholder

        foreach (var record in records)
        {
            // ManyToOneCodePlaceholder

            if (true
                // NullCheckCodePlaceholder
            )
            {
                var game = new Game
                {
                    ApplicationUserUpdatedBy = applicationUserUpdatedBy,

                    Name = record.Name,
                    // NewEntityCodePlaceholder
                };

                var dbGame = await context.Games.SingleOrDefaultAsync(
                    x => true
                    && x.NormalizedName.Equals(game.NormalizedName)
                    // CompositeKeyCodePlaceholder
                );

                if (dbGame is null)
                {
                    await context.Games.AddAsync(game);
                }
                else
                {
                    dbGame.ApplicationUserUpdatedBy = applicationUserUpdatedBy;

                    dbGame.Name = record.Name;
                    // ExistingEntityCodePlaceholder
                }
            }
        }

        await context.SaveChangesAsync();
    }
}
