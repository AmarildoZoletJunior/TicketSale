using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface ITicketRegistrationRepository : IBaseRepository<TicketRegistration>
    {
        Task<TicketRegistration> Update(TicketRegistration ticketRegistration);
        Task<int> Delete(int id);
    }
}
