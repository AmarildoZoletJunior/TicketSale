using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;

namespace TicketSale.Domain.Entities.TicketEntity
{
    public class Ticket : BaseEntity
    {
        public Client Client { get; set; }
        public int UserId { get; set; }
        public TicketRegistration TicketRegistration { get; set; }
        public int TicketRegistrationId { get; set; }

    }
}
