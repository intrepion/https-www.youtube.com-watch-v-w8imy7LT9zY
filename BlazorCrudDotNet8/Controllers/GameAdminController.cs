using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;
using BlazorCrudDotNet8.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotNet8.Controllers;

[Route("api/admin/[controller]")]
[ApiController]
public class GameController(IGameAdminService gameAdminService) : ControllerBase
{
    private readonly IGameAdminService _gameAdminService = gameAdminService;

    [HttpPost]
    public async Task<ActionResult<GameAdminDataTransferObject?>> Add(GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var databaseGameAdminDataTransferObject = await _gameAdminService.AddAsync(userName, gameAdminDataTransferObject);

        return Ok(databaseGameAdminDataTransferObject);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<GameAdminDataTransferObject?>> Delete(Guid id)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var result = await _gameAdminService.DeleteAsync(userName, id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GameAdminDataTransferObject?>> Edit(Guid id, GameAdminDataTransferObject gameAdminDataTransferObject)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var databaseGame = await _gameAdminService.EditAsync(userName, id, gameAdminDataTransferObject);

        return Ok(databaseGame);
    }

    [HttpGet]
    public async Task<ActionResult<GameAdminDataTransferObject>?> GetAll()
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var gameAdminDataTransferObjects = await _gameAdminService.GetAllAsync();

        return Ok(gameAdminDataTransferObjects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GameAdminDataTransferObject?>> GetById(Guid id)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var gameAdminDataTransferObject = await _gameAdminService.GetByIdAsync(id);

        return Ok(gameAdminDataTransferObject);
    }
}
