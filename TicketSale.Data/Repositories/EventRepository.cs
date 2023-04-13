using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class EventRepository : BaseRepository<Event>, IBaseRepository<Event>, IEventRepository
    {
        public EventRepository(TicketContext ticket) : base(ticket) { }


        public void Update(Event Event)
        {
            _ticketContext.Events.Update(Event);
        }
    }
}
