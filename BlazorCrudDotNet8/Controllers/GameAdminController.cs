using ApplicationNamePlaceholder.BusinessLogic.Entities;
using ApplicationNamePlaceholder.BusinessLogic.Entities.DataTransferObjects;
using ApplicationNamePlaceholder.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationNamePlaceholder.Controllers;

[Route("api/admin/[controller]")]
[ApiController]
public class EntityNamePlaceholderController(IEntityNamePlaceholderAdminService gameAdminService) : ControllerBase
{
    private readonly IEntityNamePlaceholderAdminService _gameAdminService = gameAdminService;

    [HttpPost]
    public async Task<ActionResult<EntityNamePlaceholderAdminDataTransferObject?>> Add(EntityNamePlaceholderAdminDataTransferObject gameAdminDataTransferObject)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var databaseEntityNamePlaceholderAdminDataTransferObject = await _gameAdminService.AddAsync(userName, gameAdminDataTransferObject);

        return Ok(databaseEntityNamePlaceholderAdminDataTransferObject);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<EntityNamePlaceholderAdminDataTransferObject?>> Delete(Guid id)
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
    public async Task<ActionResult<EntityNamePlaceholderAdminDataTransferObject?>> Edit(Guid id, EntityNamePlaceholderAdminDataTransferObject gameAdminDataTransferObject)
    {
        var userName = User.Identity?.Name;

        if (userName == null)
        {
            return Ok(null);
        }

        var databaseEntityNamePlaceholder = await _gameAdminService.EditAsync(userName, id, gameAdminDataTransferObject);

        return Ok(databaseEntityNamePlaceholder);
    }

    [HttpGet]
    public async Task<ActionResult<EntityNamePlaceholderAdminDataTransferObject>?> GetAll()
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
    public async Task<ActionResult<EntityNamePlaceholderAdminDataTransferObject?>> GetById(Guid id)
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
