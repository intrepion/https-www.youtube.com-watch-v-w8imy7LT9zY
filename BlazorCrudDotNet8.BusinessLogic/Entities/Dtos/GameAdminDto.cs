namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos;

public class GameAdminDto
{
    public string ApplicationUserName { get; set; } = string.Empty;
    public Guid Id { get; set; }

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

            Name = game.Name,
            // EntityToDtoPropertyPlaceholder
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

            Name = gameAdminDto.Name,
            // DtoToEntityPropertyPlaceholder
            // Title = gameAdminDto.Title,
            // ToDoList = gameAdminDto.ToDoList,
        };
    }
}
