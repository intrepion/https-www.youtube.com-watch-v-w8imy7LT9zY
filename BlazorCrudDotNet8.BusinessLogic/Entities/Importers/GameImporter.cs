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
            PrepareHeaderForMatch = x => x.Header.ToUpper(CultureInfo.InvariantCulture)
        });

        var records = csv.GetRecords<GameRecord>();

        foreach (var record in records)
        {
            var game = new Game
            {
                ApplicationUserUpdatedBy = applicationUserUpdatedBy,

                // NewEntityCodePlaceholder
                // Name = record.Name,
                // NormalizedName = record.Name.ToUpper(CultureInfo.InvariantCulture),
            };

            var dbGame = await context.Games.SingleOrDefaultAsync(
                x => true
                // CompositeKeyCodePlaceholder
                // && x.NormalizedName == game.NormalizedName
            );

            if (dbGame is null)
            {
                await context.Games.AddAsync(game);
            }
            else
            {
                dbGame.ApplicationUserUpdatedBy = applicationUserUpdatedBy;
            }
        }

        await context.SaveChangesAsync();
    }
}
