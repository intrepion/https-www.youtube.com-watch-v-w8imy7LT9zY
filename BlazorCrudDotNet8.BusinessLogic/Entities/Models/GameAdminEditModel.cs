using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Models;

public class GameAdminEditModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    // JustModelPropertyPlaceholder

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
            // DtoToModelPlaceholder
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

            Name = gameAdminEditModel.Name,
            // ModelToDtoPlaceholder
        };
    }
}
