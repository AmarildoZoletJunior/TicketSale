using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.UserEntity;

namespace TicketSale.Domain.Entities.ClientEntity
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CPF { get; set; }
        public string AdressInfo { get; set; }
        public DateTime Birthday { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
