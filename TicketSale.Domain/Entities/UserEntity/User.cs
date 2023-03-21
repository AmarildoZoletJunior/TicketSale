using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.ClientEntity;

namespace TicketSale.Domain.Entities.UserEntity
{
    public class User : BaseEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
