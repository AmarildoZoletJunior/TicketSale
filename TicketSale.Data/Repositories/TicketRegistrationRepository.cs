using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.Paged;
using TicketSale.Data.Context;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class TicketRegistrationRepository : BaseRepository<TicketRegistration>, IBaseRepository<TicketRegistration>, ITicketRepository
    {
        public TicketRegistrationRepository(TicketContext ticket) : base(ticket) { }


        public Task<int> Create(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        Task<Ticket> IBaseRepository<Ticket>.FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Ticket>> IBaseRepository<Ticket>.GetAllPaged(PagedParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
