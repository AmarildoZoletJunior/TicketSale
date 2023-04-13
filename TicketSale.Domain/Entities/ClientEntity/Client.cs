using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.CityEntity;
using TicketSale.Domain.Entities.TicketEntity;
using TicketSale.Domain.VO;

namespace TicketSale.Domain.Entities.ClientEntity
{
    public class Client : BaseEntity
    {

        public PersonInfo PersonInfo { get; set; }
        public string AdressInfo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; } = true;
        public City City { get; set; }
        public int CityId { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        
    }
}
