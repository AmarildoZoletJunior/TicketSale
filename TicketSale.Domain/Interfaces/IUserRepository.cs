using TicketSale.Domain.Entities.UserEntity;
using TicketSale.Domain.Interfaces.Base;

namespace TicketSale.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> Update(User user);
        Task<User> DeactivateAccount(int id);
    }
}
