using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Entities.Base;
using TicketSale.Domain.Entities.ClientEntity;
using TicketSale.Domain.Entities.PaymentStatusEntity;
using TicketSale.Domain.Entities.TicketRegistrationEntity;
using TicketSale.Domain.Interfaces;

namespace TicketSale.Domain.Entities.TicketEntity
{
    public class Ticket : BaseEntity
    {
        public PaymentStatus PaymentStatus { get; set; }
        public int PaymentStatusId { get; set; }

        public Client Client { get; set; }
        public int ClientId { get; set; }

        public TicketRegistration TicketRegistration { get; set; }
        public int TicketRegistrationId { get; set; }

    }
}
