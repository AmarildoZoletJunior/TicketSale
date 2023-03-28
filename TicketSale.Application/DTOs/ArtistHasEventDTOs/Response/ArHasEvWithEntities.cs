using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Application.DTOs.ArtistDTOs;
using TicketSale.Application.DTOs.EventDTOs.Response;

namespace TicketSale.Application.DTOs.ArtistHasEventDTOs.Response
{
    public class ArHasEvWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public EventResponseWithEntities Event { get; set; }
        public ArtistResponse Artist { get; set; }
    }
}
