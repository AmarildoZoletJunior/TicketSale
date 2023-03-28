using TicketSale.Application.DTOs.ClientDTOs.Response;
using TicketSale.Application.DTOs.PaymentStatusDTOs.Response;
using TicketSale.Application.DTOs.TicketRegistrationDTOs.Response;

namespace TicketSale.Application.DTOs.TicketDTOs.Response
{
    public class TicketResponseWithEntities
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public PaymentStatusResponse PaymentStatus { get; set; }
        public ClientResponseWithId Client { get; set; }
        public TicketRegistrationResponseWithEntities TicketRegistration { get; set; }
    }
}
