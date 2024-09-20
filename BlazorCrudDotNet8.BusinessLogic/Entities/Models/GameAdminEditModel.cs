using ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities.Models;

public class GameAdminEditModel
{
    public Guid Id { get; set; }

    // ModelPropertyPlaceholder

    public static GameAdminEditModel FromGameAdminDataTransferObject(GameAdminDataTransferObject? gameAdminDataTransferObject)
    {
        if (gameAdminDataTransferObject == null)
        {
            return new GameAdminEditModel();
        }

        return new GameAdminEditModel
        {
            Id = gameAdminDataTransferObject.Id,

            Name = gameAdminDataTransferObject.Name,
            // DtoToModelPropertyPlaceholder
        };
    }

    public static GameAdminDataTransferObject ToGameAdminDataTransferObject(GameAdminEditModel? gameAdminEditModel)
    {
        if (gameAdminEditModel == null)
        {
            return new GameAdminDataTransferObject();
        }

        return new GameAdminDataTransferObject
        {
            Id = gameAdminEditModel.Id,

            // ModelToDtoPropertyPlaceholder
        };
    }
}
