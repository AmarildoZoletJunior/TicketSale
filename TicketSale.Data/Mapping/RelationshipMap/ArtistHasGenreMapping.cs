using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.Relationship.ArtistHasGenreEntity;

namespace TicketSale.Data.Mapping.RelationshipMap
{
    public class ArtistHasGenreMapping : IEntityTypeConfiguration<ArtistHasGenre>
    {
        public void Configure(EntityTypeBuilder<ArtistHasGenre> builder)
        {
            builder.HasKey(x => new { x.GenreId, x.ArtistId });

            builder.HasOne(x => x.Artist).WithMany(x => x.Genres).HasForeignKey(x => x.ArtistId);

            builder.HasOne(x => x.Genre).WithMany(x => x.Artirts).HasForeignKey(x => x.GenreId);
        }
    }
}
