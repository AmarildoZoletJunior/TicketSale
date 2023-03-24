using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.CrossCutting.DTOs.ArtistHasEventDTOs.Response
{
    public class ArHasEvWithId
    {
        public int EventId { get; set; }
        public int ArtistId { get; set; }
    }
}
