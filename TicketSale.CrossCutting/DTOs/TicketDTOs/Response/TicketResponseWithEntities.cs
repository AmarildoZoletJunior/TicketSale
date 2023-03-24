using TicketSale.CrossCutting.DTOs.ClientDTOs.Response;
using TicketSale.CrossCutting.DTOs.PaymentStatusDTOs.Response;
using TicketSale.CrossCutting.DTOs.TicketRegistrationDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.TicketDTOs.Response
{
    public class TicketResponseWithEntities
    {
        public PaymentStatusResponse PaymentStatus { get; set; }

        public ClientResponseWithId Client { get; set; }

        public TicketRegistrationResponseWithEntities TicketRegistration { get; set; }
    }
}
