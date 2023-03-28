using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ITicketRepository : IBaseRepository<Ticket>
    {
        Task<Ticket> Update(Ticket ticket);
        Task<int> Delete(int id);
    }
}
