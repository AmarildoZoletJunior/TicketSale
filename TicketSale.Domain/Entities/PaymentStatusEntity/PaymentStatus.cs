using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.TicketEntity;

namespace TicketSale.Domain.Entities.PaymentStatusEntity
{
    public class PaymentStatus : BaseEntity
    {
        public string StatusType { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
