namespace ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;

public class GameAdminDataTransferObject
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    // DtoPropertyPlaceholder

    public static GameAdminDataTransferObject FromGame(Game? game)
    {
        if (game == null)
        {
            return new GameAdminDataTransferObject();
        }

        return new GameAdminDataTransferObject
        {
            Id = game.Id,

            Name = game.Name,
            // EntityToDtoPropertyPlaceholder
        };
    }

    public static Game ToGame(ApplicationUser applicationUser, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        return new Game
        {
            ApplicationUserUpdatedBy = applicationUser,
            Id = gameAdminDataTransferObject.Id,

            Name = gameAdminDataTransferObject.Name,
            // DtoToEntityPropertyPlaceholder
        };
    }
}
