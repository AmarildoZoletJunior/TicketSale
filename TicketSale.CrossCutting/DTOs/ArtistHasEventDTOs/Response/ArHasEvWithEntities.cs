using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.ArtistDTOs;
using TicketSale.CrossCutting.DTOs.EventDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.ArtistHasEventDTOs.Response
{
    public class ArHasEvWithEntities
    {
        public EventResponseWithEntities Event { get; set; }
        public ArtistResponse Artist { get; set; }
    }
}
