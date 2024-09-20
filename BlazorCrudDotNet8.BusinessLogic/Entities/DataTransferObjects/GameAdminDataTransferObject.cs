namespace ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;

public class EntityNamePlaceholderAdminDataTransferObject
{
    public Guid Id { get; set; }

    // DtoPropertyPlaceholder

    public static EntityNamePlaceholderAdminDataTransferObject FromEntityNamePlaceholder(EntityNamePlaceholder? game)
    {
        if (game == null)
        {
            return new EntityNamePlaceholderAdminDataTransferObject();
        }

        return new EntityNamePlaceholderAdminDataTransferObject
        {
            Id = game.Id,

            // EntityToDtoPropertyPlaceholder
        };
    }

    public static EntityNamePlaceholder ToEntityNamePlaceholder(ApplicationUser applicationUser, EntityNamePlaceholderAdminDataTransferObject gameAdminDataTransferObject)
    {
        return new EntityNamePlaceholder
        {
            ApplicationUserUpdatedBy = applicationUser,
            Id = gameAdminDataTransferObject.Id,

            // DtoToEntityPropertyPlaceholder
        };
    }
}
