using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketSale.Domain.Entities.Relationship.GenreHasEventEntity;

namespace TicketSale.Data.Mapping.RelationshipMap
{
    public class GenreHasEventMapping : IEntityTypeConfiguration<GenreHasEvent>
    {
        public void Configure(EntityTypeBuilder<GenreHasEvent> builder)
        {
            builder.HasKey(x => new { x.EventId, x.GenreId });

            builder.HasOne(x => x.Genre).WithMany(x => x.Events).HasForeignKey(x => x.GenreId);

            builder.HasOne(x => x.Event).WithMany(x => x.Genres).HasForeignKey(x => x.EventId);
        }
    }
}
