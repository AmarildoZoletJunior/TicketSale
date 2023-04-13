using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        public void Update(Event Event);
    }
}
