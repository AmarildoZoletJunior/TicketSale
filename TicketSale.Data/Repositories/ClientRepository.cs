using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Context;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IBaseRepository<Client>, IClientRepository
    {
        public ClientRepository(TicketContext ticket) : base(ticket) { }


        public Task<Client> Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
