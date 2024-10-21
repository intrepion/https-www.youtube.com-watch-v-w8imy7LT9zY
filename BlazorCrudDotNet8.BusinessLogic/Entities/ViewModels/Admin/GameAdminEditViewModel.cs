using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos.Admin;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.ViewModels.Admin;

public class GameAdminEditViewModel
{
    public Guid Id { get; set; }

    // JustModelPropertyPlaceholder

    public static GameAdminEditViewModel FromGameAdminDto(GameAdminDto gameAdminDto)
    {
        if (gameAdminDto == null)
        {
            return new GameAdminEditViewModel();
        }

        return new GameAdminEditViewModel
        {
            Id = gameAdminDto.Id,

            // DtoToModelPlaceholder
        };
    }

    public static GameAdminDto ToGameAdminDto(GameAdminEditViewModel gameAdminEditViewModel)
    {
        if (gameAdminEditViewModel == null)
        {
            return new GameAdminDto();
        }

        return new GameAdminDto
        {
            Id = gameAdminEditViewModel.Id,

            // ModelToDtoPlaceholder
        };
    }
}
