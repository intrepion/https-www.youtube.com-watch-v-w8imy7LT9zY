﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Configuration;

public class GameEtc : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasOne(x => x.ApplicationUserUpdatedBy)
            .WithMany(x => x.UpdatedGames)
            .OnDelete(DeleteBehavior.Restrict);

        // EntityConfigurationCodePlaceholder
    }
}
