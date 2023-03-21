using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.EventEntity;

namespace TicketSale.Domain.Entities.TicketRegistrationEntity
{
    public class TicketRegistration : BaseEntity
    {
        public int AvailableQuantity { get; set; }
        public bool Available { get; set; }
        public bool AgeRestriction { get; set; }
        public int LoteNumber { get; set; }
        public decimal TicketValue { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
