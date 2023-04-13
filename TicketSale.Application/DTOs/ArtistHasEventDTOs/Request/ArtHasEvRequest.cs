using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.ArtistHasEventDTOs.Request
{
    public class ArtHasEvRequest
    {
        public int EventId { get; set; }
        public int ArtistId { get; set; }
    }
}
