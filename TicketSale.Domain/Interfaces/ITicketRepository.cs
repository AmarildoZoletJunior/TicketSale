using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ITicketRepository : IBaseRepository<Ticket>
    {
        public void Update(Ticket ticket);
        public void Delete(Ticket ticket);
    }
}
