using TicketSale.Application.DTOs.CityDTOs.Response;

namespace TicketSale.Application.DTOs.EventDTOs.Response
{
    public class EventResponseWithEntities
    {
        public DateTime CreatedAt { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int AgeRestriction { get; set; }
        public CityResponseWithEntities City { get; set; }
    }
}
