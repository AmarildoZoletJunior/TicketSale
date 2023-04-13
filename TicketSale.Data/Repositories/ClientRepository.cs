using Microsoft.EntityFrameworkCore;
using TicketSale.CrossCutting.Helper;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IBaseRepository<Client>, IClientRepository
    {
        public ClientRepository(TicketContext ticket) : base(ticket) { }

        public async Task<int> AccountIsValid(string email, string password)
        {
            var passwordCrypt = CryptoHelper.EncryptPassword(password);
            var AccountFind = await _ticketContext.Clients.Where(x => x.Password == passwordCrypt).Where(x => x.Email == email).FirstOrDefaultAsync();
            if(AccountFind == null)
            {
                return 0;
            }
            return AccountFind.Id;
        }

        public async Task<bool> CPFIsUsed(string cpf)
        {
            var CpfFind = await _ticketContext.Clients.Where(x => x.PersonInfo.CPF == cpf).FirstOrDefaultAsync();
            if (CpfFind == null)
            {
                return false;
            }
            return true;
        }

        public void CryptoPasswordClient(Client client)
        {
            client.Password = CryptoHelper.EncryptPassword(client.Password);
        }

        public async Task<bool> EmailIsUsed(string email)
        {
            var emailFind = await _ticketContext.Clients.Where(x => x.Email == email).FirstOrDefaultAsync();
            if (emailFind == null)
            {
                return false;
            }
            return true;
        }

        public void Update(Client client)
        {
            _ticketContext.Clients.Update(client);
        }
    }
}
