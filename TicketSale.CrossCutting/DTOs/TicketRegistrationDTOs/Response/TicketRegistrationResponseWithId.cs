using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.EventDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.TicketRegistrationDTOs.Response
{
    public class TicketRegistrationResponseWithId
    {
        public int TicketQuantity { get; set; }
        public decimal Value { get; set; }
        public int EventId { get; set; }
    }
}
