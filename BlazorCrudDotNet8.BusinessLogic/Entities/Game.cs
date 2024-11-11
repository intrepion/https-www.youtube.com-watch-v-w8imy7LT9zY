﻿using System.ComponentModel.DataAnnotations;

namespace ApplicationNamePlaceholder.BusinessLogic.Entities;

public class Game
{
    public ApplicationUser? ApplicationUserUpdatedBy { get; set; }
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string NormalizedName { get; set; } = string.Empty;
    // ActualPropertyPlaceholder
}
