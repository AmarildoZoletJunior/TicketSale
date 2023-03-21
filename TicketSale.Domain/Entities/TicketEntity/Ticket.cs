using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Entities.UserEntity;

namespace TicketSale.Domain.Entities.TicketEntity
{
    public class Ticket : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public TicketRegistration TicketRegistration { get; set; }
        public int TicketRegistrationId { get; set; }

    }
}
