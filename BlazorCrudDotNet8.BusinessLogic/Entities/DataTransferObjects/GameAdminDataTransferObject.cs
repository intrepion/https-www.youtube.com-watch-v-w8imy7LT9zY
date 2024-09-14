namespace BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

public class GameAdminDataTransferObject
{
    public Guid Id { get; internal set; }
    public string Name { get; internal set; } = string.Empty;

    public static GameAdminDataTransferObject FromGame(Game? game)
    {
        if (game == null)
        {
            return new GameAdminDataTransferObject();
        }

        return new GameAdminDataTransferObject
        {
            Id = game.Id,
            Name = game.Name ?? string.Empty,
        };
    }

    public static Game ToGame(GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        return new Game
        {
            Id = gameAdminDataTransferObject.Id,
            Name = gameAdminDataTransferObject.Name,
        };
    }
}
