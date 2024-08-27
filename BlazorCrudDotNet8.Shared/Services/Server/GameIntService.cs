using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entities;
using BlazorCrudDotNet8.Shared.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services.Server;

public class GameIntService(ApplicationDbContext applicationDbContext) : IGameIntService
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameInt> AddAsync(GameInt gameInt)
    {
        _applicationDbContext.GameInts.Add(gameInt);
        await _applicationDbContext.SaveChangesAsync();

        return gameInt;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var dbGameInt = await _applicationDbContext.GameInts.FindAsync(id);

        if (dbGameInt == null)
        {
            return false;
        }

        _applicationDbContext.Remove(dbGameInt);
        await _applicationDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<GameInt> EditAsync(int id, GameInt gameInt)
    {
        var dbGameInt = await _applicationDbContext.GameInts.FindAsync(id);

        if (dbGameInt == null)
        {
            throw new Exception("Game guid not found.");
        }

        dbGameInt.Name = gameInt.Name;
        await _applicationDbContext.SaveChangesAsync();

        return dbGameInt;
    }

    public async Task<List<GameInt>> GetAllAsync()
    {
        var gameInts = await _applicationDbContext.GameInts.ToListAsync();

        return gameInts;
    }

    public async Task<GameInt> GetByIdAsync(int id)
    {
        return await _applicationDbContext.GameInts.FindAsync(id);
    }
}
