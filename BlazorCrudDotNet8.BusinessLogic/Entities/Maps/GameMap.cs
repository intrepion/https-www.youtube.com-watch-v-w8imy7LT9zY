using CsvHelper.Configuration;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Maps;

public sealed class GameMap : ClassMap<Game>
{
    public GameMap()
    {
        Map(m => m.Id).Ignore();
        Map(m => m.Name).Name("Name");
        Map(m => m.NormalizedName)
            .Name("Name")
            .Convert(args => args.Row.GetField("Name")?.ToUpperInvariant());
        Map(m => m.ApplicationUserUpdatedBy).Ignore();
    }
}
