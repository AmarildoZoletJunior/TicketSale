using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.ArtistHasEventDTOs.Response
{
    public class ArHasEvWithId
    {
        public DateTime CreatedAt { get; set; }
        public int EventId { get; set; }
        public int ArtistId { get; set; }
    }
}
