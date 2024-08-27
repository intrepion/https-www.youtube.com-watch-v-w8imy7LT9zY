using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.Entities;

public class GameGuidEntityTypeConfiguration : IEntityTypeConfiguration<GameGuid>
{
    public void Configure(EntityTypeBuilder<GameGuid> builder)
    {
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}
