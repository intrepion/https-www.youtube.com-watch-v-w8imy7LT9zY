using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorCrudDotNet8.Shared.Entities;

public class GameIntEntityTypeConfiguration : IEntityTypeConfiguration<GameInt>
{
    public void Configure(EntityTypeBuilder<GameInt> builder)
    {
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
}
