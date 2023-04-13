using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>, IBaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(TicketContext ticket) : base(ticket) { }

        public void Delete(Ticket ticket)
        {
            _ticketContext.Tickets.Remove(ticket);
        }

        public void Update(Ticket ticket)
        {
            _ticketContext.Tickets.Update(ticket);
        }
    }
}
