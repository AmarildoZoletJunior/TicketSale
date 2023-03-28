
namespace TicketSale.Application.DTOs.TicketDTOs.Response
{
    public class TicketResponseWithId
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PaymentStatusId { get; set; }
        public int ClientId { get; set; }
        public int TicketRegistrationId { get; set; }
    }
}
