using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Task<Client> Update(Client client);
    }
}
