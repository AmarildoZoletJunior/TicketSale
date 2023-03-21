using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSale.Domain.Enum;

namespace TicketSale.Domain.VO
{
    public struct Address
    {
        public StateAcronym Acronym { get; set; }
        public string InfoAddres { get; set; }
    }
}
