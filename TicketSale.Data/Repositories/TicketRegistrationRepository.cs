using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.Paged;
using TicketSale.Data.Repositories.Base;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Data.Repositories
{
    public class TicketRegistrationRepository : BaseRepository<TicketRegistration>, IBaseRepository<TicketRegistration>, ITicketRegistrationRepository
    {
        public TicketRegistrationRepository(TicketContext ticket) : base(ticket) { }

        public void Delete(TicketRegistration ticketRegistration)
        {
            _ticketContext.TicketRegistrations.Remove(ticketRegistration);
        }

        public void Update(TicketRegistration ticketRegistration)
        {
            _ticketContext.TicketRegistrations.Update(ticketRegistration);
        }
    }
}
