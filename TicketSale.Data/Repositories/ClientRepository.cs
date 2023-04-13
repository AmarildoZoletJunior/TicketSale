using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IBaseRepository<Client>, IClientRepository
    {
        public ClientRepository(TicketContext ticket) : base(ticket) { }

        public async Task<Client> GetClientAuthAsync(Client client)
        {
            return await _ticketContext.Clients.FirstOrDefaultAsync(x => x.Email == client.Email);
        }

        public void Update(Client client)
        {
            _ticketContext.Clients.Update(client);
        }
    }
}
