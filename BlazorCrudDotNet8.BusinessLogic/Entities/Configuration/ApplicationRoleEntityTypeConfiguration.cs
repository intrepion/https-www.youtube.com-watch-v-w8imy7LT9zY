﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Configuration;

public class ApplicationRoleEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.ToTable("AspNetRoles", x => x.IsTemporal());

        builder.HasIndex(x => x.NormalizedName).IsUnique();

        builder.HasOne(x => x.ApplicationUserUpdatedBy)
            .WithMany(x => x.UpdatedApplicationRoles)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
