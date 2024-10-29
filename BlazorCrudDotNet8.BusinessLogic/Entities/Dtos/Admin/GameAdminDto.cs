namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos.Admin;

public class GameAdminDto
{
    public string ApplicationUserName { get; set; } = string.Empty;
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    // DtoPropertyPlaceholder

    public static GameAdminDto FromGame(Game? game)
    {
        if (game == null)
        {
            return new GameAdminDto();
        }

        return new GameAdminDto
        {
            Id = game.Id,

            // EntityToDtoPlaceholder
        };
    }

    public static Game ToGame(ApplicationUser? applicationUser, GameAdminDto? gameAdminDto)
    {
        return new Game
        {
            ApplicationUserUpdatedBy = applicationUser ?? new ApplicationUser(),
            Id = gameAdminDto?.Id ?? new Guid(),

            // DtoToEntityPropertyPlaceholder
        };
    }
}
