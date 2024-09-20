using ApplicationNamePlaceholder.BusinessLogic.Data;
using ApplicationNamePlaceholder.BusinessLogic.Entities;
using ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;
using Microsoft.EntityFrameworkCore;

namespace ApplicationNamePlaceholder.BusinessLogic.Services.Server;

public class GameAdminService(ApplicationDbContext applicationDbContext) : IGameAdminService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameAdminDataTransferObject?> AddAsync(string userName, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new Exception("UserName is required.");
        }

        var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => userName.ToUpper().Equals(x.NormalizedUserName));

        if (user == null)
        {
            throw new Exception("Authentication required.");
        }

        // RequiredPropertyCodePlaceholder

        var game = GameAdminDataTransferObject.ToGame(user, gameAdminDataTransferObject);

        var result = await _applicationDbContext.Games.AddAsync(game);
        var databaseGameAdminDataTransferObject = GameAdminDataTransferObject.FromGame(result.Entity);
        await _applicationDbContext.SaveChangesAsync();

        return databaseGameAdminDataTransferObject;
    }

    public async Task<bool> DeleteAsync(string userName, Guid id)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new Exception("UserName is required.");
        }

        var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => userName.ToUpper().Equals(x.NormalizedUserName));

        if (user == null)
        {
            throw new Exception("Authentication required.");
        }

        var databaseGame = await _applicationDbContext.Games.FindAsync(id);

        if (databaseGame == null)
        {
            return false;
        }

        databaseGame.ApplicationUserUpdatedBy = user;
        await _applicationDbContext.SaveChangesAsync();

        _applicationDbContext.Remove(databaseGame);

        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<GameAdminDataTransferObject?> EditAsync(string userName, Guid id, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new Exception("UserName is required.");
        }

        var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => userName.ToUpper().Equals(x.NormalizedUserName));

        if (user == null)
        {
            throw new Exception("Authentication required.");
        }

        var databaseGame = await _applicationDbContext.Games.FindAsync(id);

        if (databaseGame == null)
        {
            throw new Exception("HumanNamePlaceholder not found.");
        }

        // EditRequiredPropertyCodePlaceholder

        databaseGame.ApplicationUserUpdatedBy = user;

        databaseGame.Name = gameAdminDataTransferObject.Name;
        // EditDatabasePropertyCodePlaceholder

        await _applicationDbContext.SaveChangesAsync();

        return gameAdminDataTransferObject;
    }

    public async Task<List<GameAdminDataTransferObject>?> GetAllAsync()
    {
        var result = await _applicationDbContext.Games.ToListAsync();

        if (result == null)
        {
            return null;
        }

        return result.Select(x => GameAdminDataTransferObject.FromGame(x)).ToList();
    }

    public async Task<GameAdminDataTransferObject?> GetByIdAsync(Guid id)
    {
        var result = await _applicationDbContext.Games.FindAsync(id);

        if (result == null)
        {
            return null;
        }

        return GameAdminDataTransferObject.FromGame(result);
    }
}
