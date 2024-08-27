using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.Shared.Entities;

public class GameStringEntityTypeConfiguration : IEntityTypeConfiguration<GameString>
{
    public void Configure(EntityTypeBuilder<GameString> builder)
    {
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}
