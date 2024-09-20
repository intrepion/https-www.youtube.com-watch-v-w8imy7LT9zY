using ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Models;

public class EntityNamePlaceholderAdminEditModel
{
    public Guid Id { get; set; }

    // ModelPropertyPlaceholder

    public static EntityNamePlaceholderAdminEditModel FromEntityNamePlaceholderAdminDataTransferObject(EntityNamePlaceholderAdminDataTransferObject? gameAdminDataTransferObject)
    {
        if (gameAdminDataTransferObject == null)
        {
            return new EntityNamePlaceholderAdminEditModel();
        }

        return new EntityNamePlaceholderAdminEditModel
        {
            Id = gameAdminDataTransferObject.Id,

            // DtoToModelPropertyPlaceholder
        };
    }

    public static EntityNamePlaceholderAdminDataTransferObject ToEntityNamePlaceholderAdminDataTransferObject(EntityNamePlaceholderAdminEditModel? gameAdminEditModel)
    {
        if (gameAdminEditModel == null)
        {
            return new EntityNamePlaceholderAdminDataTransferObject();
        }

        return new EntityNamePlaceholderAdminDataTransferObject
        {
            Id = gameAdminEditModel.Id,

            // ModelToDtoPropertyPlaceholder
        };
    }
}
