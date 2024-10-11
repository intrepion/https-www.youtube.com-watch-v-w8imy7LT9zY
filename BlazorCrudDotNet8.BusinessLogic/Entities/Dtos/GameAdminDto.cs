namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos;

public class GameAdminDto
{
    public string ApplicationUserName { get; set; } = string.Empty;
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    // DtoPropertyPlaceholder
    // public string Title { get; set; } = string.Empty;
    // public ToDoList? ToDoList { get; set; }

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
            // Title = game.Title,
            // ToDoList = game.ToDoList,
        };
    }

    public static Game ToGame(ApplicationUser applicationUser, GameAdminDto gameAdminDto)
    {
        return new Game
        {
            ApplicationUserUpdatedBy = applicationUser,
            Id = gameAdminDto.Id,

            // DtoToEntityPropertyPlaceholder
            // Title = gameAdminDto.Title,
            // ToDoList = gameAdminDto.ToDoList,
        };
    }
}
