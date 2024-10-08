﻿namespace BlazorCrudDotNet8.BusinessLogic.Entities;

public class Game
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string NormalizedName { get; set; } = string.Empty;
    // ActualPropertyPlaceholder
}
