using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.CategoryEntity;
using TicketSale.Domain.Entities.EventEntity;

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
