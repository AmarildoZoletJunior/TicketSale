using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.VO;

namespace TicketSale.Domain.Entities.ClientEntity
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Address Adress { get; set; }
    }
}
