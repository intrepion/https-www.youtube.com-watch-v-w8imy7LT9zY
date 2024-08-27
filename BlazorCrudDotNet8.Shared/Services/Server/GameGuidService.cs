using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class GameGuidService(ApplicationDbContext applicationDbContext) : IGameGuidService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameGuid> AddAsync(GameGuid gameGuid)
    {
        _applicationDbContext.GameGuids.Add(gameGuid);
        await _applicationDbContext.SaveChangesAsync();

        return gameGuid;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var dbGameGuid = await _applicationDbContext.GameGuids.FindAsync(id);

        if (dbGameGuid == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbGameGuid);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<GameGuid> EditAsync(Guid id, GameGuid gameGuid)
    {
        var dbGameGuid = await _applicationDbContext.GameGuids.FindAsync(id);

        if (dbGameGuid == null)
        {
            throw new Exception("Game guid not found.");
        }

        dbGameGuid.Name = gameGuid.Name;
        await _applicationDbContext.SaveChangesAsync();

        return dbGameGuid;
    }

    public async Task<List<GameGuid>> GetAllAsync()
    {
        var gameGuids = await _applicationDbContext.GameGuids.ToListAsync();

        return gameGuids;
    }

    public async Task<GameGuid> GetByIdAsync(Guid id)
    {
        return await _applicationDbContext.GameGuids.FindAsync(id);
    }
}
