using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.EventEntity;
using TicketSale.Domain.Entities.StateEntity;

namespace TicketSale.Domain.Entities.CityEntity
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<Client>? Clients { get; set; }
    }
}
