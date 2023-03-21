using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.CategoryEntity;
using TicketSale.Domain.VO;

namespace TicketSale.Domain.Entities.EventEntity
{
    public class Event : BaseEntity
    {
        public DateTime FinalDate { get; set; }
        public DateTime InitialDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Address Address { get; set; }
    }
}
