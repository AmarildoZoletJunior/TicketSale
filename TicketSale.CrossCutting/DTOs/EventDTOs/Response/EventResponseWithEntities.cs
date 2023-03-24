using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.CrossCutting.DTOs.CityDTOs.Response;

namespace TicketSale.CrossCutting.DTOs.EventDTOs.Response
{
    public class EventResponseWithEntities
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int AgeRestriction { get; set; }
        public CityResponseWithEntities CityId { get; set; }

    }
}
