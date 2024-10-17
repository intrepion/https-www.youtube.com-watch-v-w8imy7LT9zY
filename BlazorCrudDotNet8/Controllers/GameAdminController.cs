using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos;
using BlazorCrudDotNet8.BusinessLogic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/admin/[controller]")]
[ApiController]
public class GameController(IGameAdminRepository gameAdminRepository) : ControllerBase
{
    private readonly IGameAdminRepository _gameAdminRepository = gameAdminRepository;

    [HttpPost]
    public async Task<ActionResult<GameAdminDto?>> Add(GameAdminDto gameAdminDto)
    {
        var userIdentityName = User.Identity?.Name;

        if (string.IsNullOrWhiteSpace(userIdentityName))
        {
            return Ok(null);
        }

        if (string.Equals(gameAdminDto.ApplicationUserName, userIdentityName, StringComparison.InvariantCultureIgnoreCase))
        {
            return Ok(null);
        }

        var databaseGameAdminDto = await _gameAdminRepository.AddAsync(gameAdminDto);

        return Ok(databaseGameAdminDto);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool?>> Delete(string userName, Guid id)
    {
        var userIdentityName = User.Identity?.Name;

        if (string.IsNullOrWhiteSpace(userIdentityName))
        {
            return Ok(null);
        }

        if (string.Equals(userName, userIdentityName, StringComparison.InvariantCultureIgnoreCase))
        {
            return Ok(null);
        }

        var result = await _gameAdminRepository.DeleteAsync(userIdentityName, id);

        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<GameAdminDto?>> Edit(GameAdminDto gameAdminDto)
    {
        var userIdentityName = User.Identity?.Name;

        if (string.IsNullOrWhiteSpace(userIdentityName))
        {
            return Ok(null);
        }

        if (string.Equals(gameAdminDto.ApplicationUserName, userIdentityName, StringComparison.InvariantCultureIgnoreCase))
        {
            return Ok(null);
        }

        var databaseGame = await _gameAdminRepository.EditAsync(gameAdminDto);

        return Ok(databaseGame);
    }

    [HttpGet]
    public async Task<ActionResult<GameAdminDto>?> GetAll(string userName)
    {
        var userIdentityName = User.Identity?.Name;

        if (string.IsNullOrWhiteSpace(userIdentityName))
        {
            return Ok(null);
        }

        if (string.Equals(userName, userIdentityName, StringComparison.InvariantCultureIgnoreCase))
        {
            return Ok(null);
        }

        var gameAdminDtos = await _gameAdminRepository.GetAllAsync(userIdentityName);

        return Ok(gameAdminDtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameAdminDto?>> GetById(string userName, Guid id)
    {
        var userIdentityName = User.Identity?.Name;

        if (string.IsNullOrWhiteSpace(userIdentityName))
        {
            return Ok(null);
        }

        if (string.Equals(userName, userIdentityName, StringComparison.InvariantCultureIgnoreCase))
        {
            return Ok(null);
        }

        var gameAdminDto = await _gameAdminRepository.GetByIdAsync(userIdentityName, id);

        return Ok(gameAdminDto);
    }
}
