using System.ComponentModel.DataAnnotations;
using ApplicationNamePlaceholder.BusinessLogic.Entities.Dtos.Admin;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Vms.Admin;

public class EntityNamePlaceholderAdminEditVm
{
    public Guid Id { get; set; }

    // JustModelPropertyPlaceholder

    public static EntityNamePlaceholderAdminEditVm FromEntityNamePlaceholderAdminDto(EntityNamePlaceholderAdminDto gameAdminDto)
    {
        if (gameAdminDto == null)
        {
            return new EntityNamePlaceholderAdminEditVm();
        }

        return new EntityNamePlaceholderAdminEditVm
        {
            Id = gameAdminDto.Id,

            // DtoToModelPlaceholder
        };
    }

    public static EntityNamePlaceholderAdminDto ToEntityNamePlaceholderAdminDto(EntityNamePlaceholderAdminEditVm gameAdminEditVm)
    {
        if (gameAdminEditVm == null)
        {
            return new EntityNamePlaceholderAdminDto();
        }

        return new EntityNamePlaceholderAdminDto
        {
            Id = gameAdminEditVm.Id,

            // ModelToDtoPlaceholder
        };
    }
}
