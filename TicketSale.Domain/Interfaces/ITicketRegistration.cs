using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ITicketRegistration : IBaseRepository<TicketRegistration>
    {
    }
}
