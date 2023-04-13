using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        public void Update(Client client);
        public void CryptoPasswordClient(Client client);
        public Task<bool> EmailIsUsed(string email);
        public Task<bool> CPFIsUsed(string cpf );
        public Task<int> AccountIsValid(string email, string password);
    }
}
