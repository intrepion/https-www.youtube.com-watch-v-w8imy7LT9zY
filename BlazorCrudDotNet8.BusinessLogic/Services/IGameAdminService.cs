using BlazorCrudDotNet8.BusinessLogic.Entities;
using BlazorCrudDotNet8.BusinessLogic.Entities.DataTransferObjects;

namespace BlazorCrudDotNet8.BusinessLogic.Services;

public interface IGameAdminService
{
    Task<Game?> AddAsync(string userName, Game game);
    Task<bool> DeleteAsync(string userName, Guid id);
    Task<Game?> EditAsync(string userName, Guid id, Game game);
    Task<List<Game>?> GetAllAsync();
    Task<Game?> GetByIdAsync(Guid id);
    Task<int> GetCountAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<GameAdminDataTransferObject>> GetDataFragmentAsync(int startIndex, int? count, CancellationToken cancellationToken = default);
}
