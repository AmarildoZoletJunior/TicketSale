using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity;

namespace TicketSale.Data.Mapping.RelationshipMap
{
    public class ArtistHasEventMapping : IEntityTypeConfiguration<ArtistHasEvent>
    {
        public void Configure(EntityTypeBuilder<ArtistHasEvent> builder)
        {
            builder.HasKey(x => new { x.EventId, x.ArtistId });

            builder.HasOne(x => x.Artist).WithMany(x => x.Events).HasForeignKey(x => x.ArtistId);

            builder.HasOne(x => x.Event).WithMany(x => x.Artirts).HasForeignKey(x => x.EventId);
        }
    }
}
