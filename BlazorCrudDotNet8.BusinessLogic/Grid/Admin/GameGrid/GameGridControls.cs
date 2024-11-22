namespace BlazorCrudDotNet8.BusinessLogic.Grid.Admin.GameGrid;

public class GameGridControls(IPageHelper pageHelper) : IGameFilters
{
    public IPageHelper PageHelper { get; set; } = pageHelper;

    public bool Loading { get; set; }

    public GameFilterColumns SortColumn { get; set; } = GameFilterColumns.Id;

    public bool SortAscending { get; set; } = true;

    public GameFilterColumns FilterColumn { get; set; } = GameFilterColumns.Id;

    public string? FilterText { get; set; }
}
