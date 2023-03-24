using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IEvent : IBaseRepository<Event>
    {

    }
}
