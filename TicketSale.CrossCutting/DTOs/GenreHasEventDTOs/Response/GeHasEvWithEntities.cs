using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.EventDTOs.Response;
using TicketSale.CrossCutting.DTOs.GenreDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.GenreHasEventDTOs.Response
{
    public class GeHasEvWitEntities
    {
        public EventResponseWithEntities Event { get; set; }
        public GenreResponse Genre { get; set; }
    }
}
