using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ITicketRegistrationRepository : IBaseRepository<TicketRegistration>
    {
        public void Update(TicketRegistration ticketRegistration);
        public void Delete(TicketRegistration ticketRegistration);
    }
}
