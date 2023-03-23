using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.ArtistEntity;
using TicketSale.Domain.Entities.EventEntity;

namespace TicketSale.Domain.Entities.ArtistHasEventEntity
{
    public class ArtistHasEvent
    {
        public Event Event { get; set; }
        public int EventId { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }

    }
}
