using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Models;

public class GameAdminEditModel
{
    public Guid Id { get; set; }

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

            // ModelToDtoPlaceholder
        };
    }
}
