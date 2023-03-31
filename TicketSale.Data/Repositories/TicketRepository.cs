using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Context;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>, IBaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketContext ticket) : base(ticket) { }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
