using TicketSale.Application.DTOs.EventDTOs.Response;
using TicketSale.Application.DTOs.GenreDTOs.Response;

namespace TicketSale.Application.DTOs.GenreHasEventDTOs.Response
{
    public class GeHasEvWitEntities
    {

        public EventResponseWithEntities Event { get; set; }
        public GenreResponse Genre { get; set; }
    }
}
