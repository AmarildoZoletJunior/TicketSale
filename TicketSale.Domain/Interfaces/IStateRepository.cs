using TicketSale.Domain.Entities.StateEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IStateRepository : IBaseRepository<State>
    {
        Task<State> Update(State state);
    }
}
