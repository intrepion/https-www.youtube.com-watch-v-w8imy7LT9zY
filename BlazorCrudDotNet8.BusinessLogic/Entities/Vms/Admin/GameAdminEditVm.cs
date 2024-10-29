using System.ComponentModel.DataAnnotations;
using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos.Admin;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Vms.Admin;

public class GameAdminEditVm
{
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    // JustModelPropertyPlaceholder

    public static GameAdminEditVm FromGameAdminDto(GameAdminDto gameAdminDto)
    {
        if (gameAdminDto == null)
        {
            return new GameAdminEditVm();
        }

        return new GameAdminEditVm
        {
            Id = gameAdminDto.Id,

            Name = gameAdminDto?.Name ?? string.Empty,
            // DtoToModelPlaceholder
        };
    }

    public static GameAdminDto ToGameAdminDto(GameAdminEditVm gameAdminEditVm)
    {
        if (gameAdminEditVm == null)
        {
            return new GameAdminDto();
        }

        return new GameAdminDto
        {
            Id = gameAdminEditVm.Id,

            Name = gameAdminEditVm.Name,
            // ModelToDtoPlaceholder
        };
    }
}
