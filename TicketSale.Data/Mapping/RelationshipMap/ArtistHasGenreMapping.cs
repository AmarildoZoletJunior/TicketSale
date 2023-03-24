using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.ArtistHasGenreEntity;

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
