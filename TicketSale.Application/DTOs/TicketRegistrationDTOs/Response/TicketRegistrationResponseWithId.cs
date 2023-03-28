namespace TicketSale.Application.DTOs.TicketRegistrationDTOs.Response
{
    public class TicketRegistrationResponseWithId
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TicketQuantity { get; set; }
        public decimal Value { get; set; }
        public int EventId { get; set; }
    }
}
