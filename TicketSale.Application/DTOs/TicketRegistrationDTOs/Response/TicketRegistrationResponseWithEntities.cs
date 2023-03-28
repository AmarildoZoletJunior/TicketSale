using TicketSale.Application.DTOs.EventDTOs.Response;

namespace TicketSale.Application.DTOs.TicketRegistrationDTOs.Response
{
    public class TicketRegistrationResponseWithEntities
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TicketQuantity { get; set; }
        public decimal Value { get; set; }
        public EventResponseWithEntities Event { get; set; }
    }
}
