using ApplicationNamePlaceholder.BusinessLogic.Entities;
using ApplicationNamePlaceholder.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationNamePlaceholder.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameAdminController(IGameAdminService gameAdminService) : ControllerBase
{
    private readonly IGameAdminService _gameAdminService = gameAdminService;

    [HttpPost]
    public async Task<ActionResult<Game?>> Add(Game game)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var addedGame = await _gameAdminService.AddAsync(userName, game);

        return Ok(addedGame);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Game?>> Delete(Guid id)
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
    public async Task<ActionResult<Game?>> Edit(Guid id, Game game)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var updatedGame = await _gameAdminService.EditAsync(userName, id, game);

        return Ok(updatedGame);
    }

    [HttpGet]
    public async Task<ActionResult<Game>?> GetAll()
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var games = await _gameAdminService.GetAllAsync();

        return Ok(games);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Game?>> GetById(Guid id)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var game = await _gameAdminService.GetByIdAsync(id);

        return Ok(game);
    }
}
