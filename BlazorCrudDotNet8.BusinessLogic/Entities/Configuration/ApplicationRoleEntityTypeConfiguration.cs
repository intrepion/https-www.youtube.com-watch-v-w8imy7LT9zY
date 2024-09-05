﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.Configuration;

public class ApplicationRoleEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.ToTable("AspNetRoles", x => x.IsTemporal());

        builder.Property(x => x.Name).IsRequired();

        builder.Property(x => x.NormalizedName).IsRequired();

        builder.HasIndex(x => x.NormalizedName).IsUnique();

        builder.HasOne(x => x.ApplicationUserUpdatedBy)
            .WithMany(x => x.UpdatedApplicationRoles)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}
