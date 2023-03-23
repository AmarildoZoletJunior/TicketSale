using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Domain.Entities.TicketRegistrationEntity
{
    public class TicketRegistration : BaseEntity
    {
        public int TicketQuantity { get; set; }
        public decimal Value { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}
