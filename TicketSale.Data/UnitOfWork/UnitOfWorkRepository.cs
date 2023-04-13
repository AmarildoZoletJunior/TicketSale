using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Relationship;
using XAct.Domain.Repositories;

namespace TicketSale.Data.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly TicketContext _ticketContext;

        public UnitOfWorkRepository(TicketContext ticketContext)
        {
            _ticketContext = ticketContext;
        }
        public async Task Commit()
        {
            await _ticketContext.SaveChangesAsync();
        }
    }
}
