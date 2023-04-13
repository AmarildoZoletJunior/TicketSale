using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Application.DTOs.CityDTOs.Request
{
    public class CityRequest
    {
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
