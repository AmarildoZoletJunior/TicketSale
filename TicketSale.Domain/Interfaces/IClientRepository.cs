using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        public void Update(Client client);
        public Task<Client> GetClientAuthAsync(Client client);
    }
}
