﻿using BlazorCrudDotNet8.BusinessLogic.Data;
using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos.Admin;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.BusinessLogic.Repositories.Admin.Server;

public class GameAdminRepository(ApplicationDbContext applicationDbContext) : IGameAdminRepository
{
    private readonly ApplicationDbContext _applicationDbContext = applicationDbContext;

    public async Task<GameAdminDto?> AddAsync(GameAdminDto gameAdminDto)
    {
        if (string.IsNullOrWhiteSpace(gameAdminDto.ApplicationUserName))
        {
            throw new Exception("UserName is required.");
        }

        var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => gameAdminDto.ApplicationUserName.ToUpper().Equals(x.NormalizedUserName));

        if (user == null)
        {
            throw new Exception("Authentication required.");
        }

        if (string.IsNullOrWhiteSpace(gameAdminDto.Name))
        {
            throw new Exception("Name required.");
        }

        // AddRequiredPropertyCodePlaceholder

        var game = GameAdminDto.ToGame(user, gameAdminDto);

        game.NormalizedName = gameAdminDto.Name.ToUpperInvariant();
        // AddDatabasePropertyCodePlaceholder

        var result = await _applicationDbContext.Games.AddAsync(game);
        var databaseGameAdminDto = GameAdminDto.FromGame(result.Entity);
        await _applicationDbContext.SaveChangesAsync();

        return databaseGameAdminDto;
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

    public async Task<GameAdminDto?> EditAsync(GameAdminDto gameAdminDto)
    {
        if (string.IsNullOrWhiteSpace(gameAdminDto.ApplicationUserName))
        {
            throw new Exception("UserName is required.");
        }

        var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => gameAdminDto.ApplicationUserName.ToUpper().Equals(x.NormalizedUserName));

        if (user == null)
        {
            throw new Exception("Authentication required.");
        }

        var databaseGame = await _applicationDbContext.Games.FindAsync(gameAdminDto.Id);

        if (databaseGame == null)
        {
            throw new Exception("HumanNamePlaceholder not found.");
        }

        if (string.IsNullOrWhiteSpace(gameAdminDto.Name))
        {
            throw new Exception("Name required.");
        }

        // EditRequiredPropertyCodePlaceholder

        databaseGame.ApplicationUserUpdatedBy = user;

        databaseGame.Name = gameAdminDto.Name;
        databaseGame.NormalizedName = gameAdminDto.Name.ToUpperInvariant();
        // EditDatabasePropertyCodePlaceholder

        await _applicationDbContext.SaveChangesAsync();

        return gameAdminDto;
    }

    public async Task<List<GameAdminDto>?> GetAllAsync(string userName)
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

        return await _applicationDbContext.Games

            // IncludeTableCodePlaceholder

            .Select(x => GameAdminDto.FromGame(x))
            .ToListAsync();
    }

    public async Task<GameAdminDto?> GetByIdAsync(string userName, Guid id)
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

        var result = await _applicationDbContext.Games.FindAsync(id);

        if (result == null)
        {
            return null;
        }

        return GameAdminDto.FromGame(result);
    }
}
