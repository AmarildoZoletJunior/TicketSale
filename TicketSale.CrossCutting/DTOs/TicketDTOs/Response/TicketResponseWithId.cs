using TicketSale.CrossCutting.DTOs.ClientDTOs.Response;
using TicketSale.CrossCutting.DTOs.PaymentStatusDTOs.Response;
using TicketSale.CrossCutting.DTOs.TicketRegistrationDTOs;

namespace TicketSale.CrossCutting.DTOs.TicketDTOs.Response
{
    public class TicketResponseWithId
    {
        public int PaymentStatusId { get; set; }

        public int ClientId { get; set; }

        public int TicketRegistrationId { get; set; }
    }
}
