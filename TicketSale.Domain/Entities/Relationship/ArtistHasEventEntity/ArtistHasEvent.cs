using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.EventEntity;

namespace TicketSale.Domain.Entities.Relationship.ArtistHasEventEntity
{
    public class ArtistHasEvent
    {
        public Event Event { get; set; }
        public int EventId { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }

    }
}
