namespace BlazorCrudDotNet8.BusinessLogic.Grid.Admin.GameGrid;

public interface IGameFilters
{
    GameFilterColumns FilterColumn { get; set; }

    bool Loading { get; set; }

    string? FilterText { get; set; }

    IPageHelper PageHelper { get; set; }

    bool SortAscending { get; set; }

    GameFilterColumns SortColumn { get; set; }
}
