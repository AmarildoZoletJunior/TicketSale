using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.TicketEntity;

namespace TicketSale.Domain.Entities.TicketRegistrationEntity
{
    public class TicketRegistration : BaseEntity
    {
        public int TicketQuantity { get; set; }
        public decimal Value { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
