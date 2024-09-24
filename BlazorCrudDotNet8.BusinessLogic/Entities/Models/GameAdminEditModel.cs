using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Models;

public class GameAdminEditModel
{
    public Guid Id { get; set; }

    // JustModelPropertyPlaceholder
    // public string Title { get; set; } = string.Empty;
    // public ToDoList? ToDoList { get; set; }

    public static GameAdminEditModel FromGameAdminDto(GameAdminDto gameAdminDto)
    {
        if (gameAdminDto == null)
        {
            return new GameAdminEditModel();
        }

        return new GameAdminEditModel
        {
            Id = gameAdminDto.Id,

            Name = gameAdminDto.Name,
            // DtoToModelPropertyPlaceholder
            // Title = gameAdminDto.Title,
            // ToDoList = gameAdminDto.ToDoList,
        };
    }

    public static GameAdminDto ToGameAdminDto(GameAdminEditModel gameAdminEditModel)
    {
        if (gameAdminEditModel == null)
        {
            return new GameAdminDto();
        }

        return new GameAdminDto
        {
            Id = gameAdminEditModel.Id,

            // ModelToDtoPropertyPlaceholder
            // Title = gameAdminEditModel.Title,
            // ToDoList = gameAdminEditModel.ToDoList,
        };
    }
}
