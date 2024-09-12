using ApplicationNamePlaceholder.BusinessLogic.Data;
using ApplicationNamePlaceholder.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationNamePlaceholder.BusinessLogic.Services.Server;

public class GameAdminService(ApplicationDbContext applicationDbContext) : IGameAdminService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<Game?> AddAsync(string userName, Game EntityLowercaseNamePlaceholder)
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

        // if (string.IsNullOrWhiteSpace(EntityLowercaseNamePlaceholder.PropertyNamePlaceholder))
        // {
        //     throw new Exception("Name required.");
        // }

        EntityLowercaseNamePlaceholder.ApplicationUserUpdatedBy = user;
        // EntityLowercaseNamePlaceholder.NormalizedPropertyNamePlaceholder = EntityLowercaseNamePlaceholder.PropertyNamePlaceholder?.ToUpper();

        _applicationDbContext.Games.Add(EntityLowercaseNamePlaceholder);

        await _applicationDbContext.SaveChangesAsync();

        return EntityLowercaseNamePlaceholder;
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

        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame == null)
        {
            return false;
        }

        dbGame.ApplicationUserUpdatedBy = user;
        await _applicationDbContext.SaveChangesAsync();

        _applicationDbContext.Remove(dbGame);

        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<Game?> EditAsync(string userName, Guid id, Game EntityLowercaseNamePlaceholder)
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

        var dbGame = await _applicationDbContext.Games.FindAsync(id);

        if (dbGame == null)
        {
            throw new Exception("Application role not found.");
        }

        // if (string.IsNullOrWhiteSpace(EntityLowercaseNamePlaceholder.PropertyNamePlaceholder))
        // {
        //     throw new Exception("PropertyNamePlaceholder required.");
        // }

        dbGame.ApplicationUserUpdatedBy = user;
        // dbGame.PropertyNamePlaceholder = EntityLowercaseNamePlaceholder.PropertyNamePlaceholder;
        // dbGame.NormalizedPropertyNamePlaceholder = EntityLowercaseNamePlaceholder.PropertyNamePlaceholder?.ToUpper();

        await _applicationDbContext.SaveChangesAsync();

        return dbGame;
    }

    public async Task<List<Game>?> GetAllAsync()
    {
        return await _applicationDbContext.Games.Include(x => x.ApplicationUserUpdatedBy).ToListAsync();
    }

    public async Task<Game?> GetByIdAsync(Guid id)
    {
        return await _applicationDbContext.Games.FindAsync(id);
    }
}
