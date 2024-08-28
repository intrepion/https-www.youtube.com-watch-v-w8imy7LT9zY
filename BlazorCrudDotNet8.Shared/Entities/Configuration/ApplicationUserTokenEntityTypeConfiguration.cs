﻿using BlazorCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.Shared.Entities.Configuration;

public class ApplicationUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUserToken>
{
    public void Configure(EntityTypeBuilder<ApplicationUserToken> builder)
    {
        builder
            .ToTable("AspNetUserTokens", x => x.IsTemporal());

        builder
            .HasOne(x => x.ApplicationUserUpdatedBy)
            .WithMany(x => x.UpdatedApplicationUserTokens)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}
