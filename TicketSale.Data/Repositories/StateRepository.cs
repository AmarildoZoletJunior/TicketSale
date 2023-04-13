using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.StateEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class StateRepository : BaseRepository<State>, IBaseRepository<State>, IStateRepository
    {
        public StateRepository(TicketContext ticket) : base(ticket) { }


        public void Update(State state)
        {
            _ticketContext.States.Update(state);
        }
    }
}
