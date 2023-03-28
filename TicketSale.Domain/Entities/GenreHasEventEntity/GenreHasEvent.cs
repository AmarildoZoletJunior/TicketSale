using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.GenreEntity;

namespace TicketSale.Domain.Entities.GenreHasEventEntity
{
    public class GenreHasEvent
    {
        public Event Event { get; set; }
        public int EventId { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
