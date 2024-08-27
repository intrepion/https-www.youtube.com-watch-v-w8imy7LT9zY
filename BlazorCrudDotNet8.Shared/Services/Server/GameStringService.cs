using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class GameStringService(ApplicationDbContext applicationDbContext) : IGameStringService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameString> AddAsync(GameString gameString)
    {
        _applicationDbContext.GameStrings.Add(gameString);
        await _applicationDbContext.SaveChangesAsync();

        return gameString;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var dbGameString = await _applicationDbContext.GameStrings.FindAsync(id);

        if (dbGameString == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbGameString);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<GameString> EditAsync(string id, GameString gameString)
    {
        var dbGameString = await _applicationDbContext.GameStrings.FindAsync(id);

        if (dbGameString == null)
        {
            throw new Exception("Game guid not found.");
        }

        dbGameString.Name = gameString.Name;
        await _applicationDbContext.SaveChangesAsync();

        return dbGameString;
    }

    public async Task<List<GameString>> GetAllAsync()
    {
        var gameStrings = await _applicationDbContext.GameStrings.ToListAsync();

        return gameStrings;
    }

    public async Task<GameString> GetByIdAsync(string id)
    {
        return await _applicationDbContext.GameStrings.FindAsync(id);
    }
}
